using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SPS_Helper
{
    public static class SqlCommands
    {
        static Dictionary<string, string> SqlQueries = new Dictionary<string, string>();
        
        struct LastExecutedSQLCommand
        {
            string ConnectionString;
            string CommandText;
            DateTime ExecStart;
            DateTime ExecFinish;
        }

        public static void Initialize()
        {
            /*
            SqlQueries.Add("GetReports", "set transaction isolation level read uncommitted \n" +
                "select subsc.SubscriptionID,\n" +
                "        subsc.[Description] as SubscriprionName,\n" +
                "        report.ItemID as ReportID,\n" +
                "        report.[Name] as ReportName,\n" +
                "        shed_owner.UserID as CreatedByID,\n" +
                "        shed_owner.UserName as CreatedByName,\n" +
                "        shed_mod.UserID as ModifiedByID,\n" +
                "        shed_mod.UserName as ModifiedByName,\n" +
                "        convert(nvarchar(20), subsc.ModifiedDate, 104) + N' ' + convert(nvarchar(20), subsc.ModifiedDate, 108) as ModifiedDate,\n" +
                "        convert(nvarchar(20), subsc.[LastRunTime], 104) + N' ' + convert(nvarchar(20), subsc.[LastRunTime], 108) as [LastRunTime],\n" +
                "        cast(Parameters as xml) as ReportParameters,\n" +
                "        cast(ExtensionSettings as xml) as EmailParameters,\n" +
                "        cast(replace(cast(MatchData as nvarchar(max)), N'<?xml version=\"1.0\" encoding=\"utf-16\" standalone=\"yes\"?>', N'') as xml) as Schedule,\n" +
                "        cast([DataSettings] as xml).query('./DataSet[1]/Query[1]/CommandText[1]') as Script\n" +
                "        " +
                "from Subscriptions subsc\n" +
                "    join [Catalog] report\n" +
                "        on report.ItemID = subsc.Report_OID\n" +
                "    join [Users] shed_owner\n" +
                "        on shed_owner.UserID = subsc.OwnerID\n" +
                "    join Users shed_mod\n" +
                "        on shed_mod.UserID = subsc.ModifiedByID\n");
            */
            SqlQueries.Add("GetReports", "set transaction isolation level read uncommitted \n" +
                            "select subsc.SubscriptionID,\n" +
                            "        subsc.[Description] as SubscriprionName,\n" +
                            "        report.ItemID as ReportID,\n" +
                            "        report.[Name] as ReportName,\n" +
                            "        shed_owner.UserID as CreatedByID,\n" +
                            "        shed_owner.UserName as CreatedByName,\n" +
                            "        shed_mod.UserID as ModifiedByID,\n" +
                            "        shed_mod.UserName as ModifiedByName,\n" +
                            "        convert(nvarchar(20), subsc.ModifiedDate, 104) + N' ' + convert(nvarchar(20), subsc.ModifiedDate, 108) as ModifiedDate,\n" +
                            "        convert(nvarchar(20), subsc.[LastRunTime], 104) + N' ' + convert(nvarchar(20), subsc.[LastRunTime], 108) as [LastRunTime],\n" +
                            "        cast(Parameters as xml) as ReportParameters,\n" +
                            "        cast(ExtensionSettings as xml) as EmailParameters,\n" +
                            "        cast(replace(cast(MatchData as nvarchar(max)), N'<?xml version=\"1.0\" encoding=\"utf-16\" standalone=\"yes\"?>', N'') as xml) as Schedule,\n" +
                            "        cast([DataSettings] as xml).query('./DataSet[1]/Query[1]/CommandText[1]') as Script\n" +
                            "        " +
                            "from Subscriptions subsc\n" +
                            "    join [Catalog] report\n" +
                            "        on report.ItemID = subsc.Report_OID\n" +
                            "    join [Users] shed_owner\n" +
                            "        on shed_owner.UserID = subsc.OwnerID\n" +
                            "    join Users shed_mod\n" +
                            "        on shed_mod.UserID = subsc.ModifiedByID\n");

            SqlQueries.Add("GetColumns", "exec sys.sp_describe_first_result_set @tsql = N'{query}'");
        }


        public static string GetCommandTextByName(string CommandName)
        {
            string CommandText = "";

            SqlQueries.TryGetValue(CommandName, out CommandText);

            return CommandText;
        }

        public static /*async void*/DataGridView ExecuteSQLCommand(int ConnectionID,string SQLtext/*,out DataGridView prepare_data*/, bool ByAlias = true)
        {

            DataGridView prepare_data = new DataGridView();
            DataGridView result = new DataGridView();

            SqlDataReader SqlReader = null;
            
            string command_text = "";
            string prepare_text = "";

            //List<string> columns = new List<string>();
            
            
            if (ByAlias = true)
                command_text = GetCommandTextByName(SQLtext);

            prepare_text = GetCommandTextByName("GetColumns");
            prepare_text = prepare_text.Replace("{query}", command_text.Replace("'","''"));

            SqlConnection connection = Connections.GetConnection(ConnectionID);
            SqlCommand command = new SqlCommand(command_text);
            SqlCommand prepare_command = new SqlCommand(prepare_text);

            prepare_command.Connection = connection;

            string header = "";
            int row_number = 0;

            try
            {
                SqlReader = prepare_command.ExecuteReader();
                if (SqlReader.HasRows)
                {
                    

                    for (int i = 0; i < SqlReader.FieldCount; i++)
                    {
                        header = SqlReader.GetName(i);
                        prepare_data.Columns.Add(header, header);
                    }

                    while(SqlReader.Read())
                    {
                        prepare_data.Rows.Add();
                        for (int j = 0; j < SqlReader.FieldCount; j++)
                            prepare_data.Rows[row_number].Cells[j].Value = SqlReader.GetValue(j);
                        row_number++;
                        
                    }

                    //MessageBox.Show(prepare_data.RowCount.ToString() + "/rownumber =  " + row_number.ToString(),"Колво строк в preparedata");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(prepare_command.CommandText,"Ошибка запуска запроса:");
                MessageBox.Show(ex.Message, ex.Source);
                MessageBox.Show("Error getting columns");
            }
            finally
            {
                if (SqlReader != null)
                    SqlReader.Close();
            }
            

            command.Connection = connection;
            //MessageBox.Show(SQLtext);
            //MessageBox.Show(command.CommandText);   
            try
            {
                SqlReader = /*await*/ command.ExecuteReader/*Async*/();
                if (SqlReader.HasRows)
                {
                    row_number = 0;
                    header = "";

                    //MessageBox.Show("reader executed");

                    //Добавляем колонки в итоговый DataGridView
                    if (prepare_data.RowCount > 1)
                    {
                        for (int i = 0; i < prepare_data.RowCount - 1; i++) //почемуто неправильно считает колво строк
                        {
                            header = prepare_data.Rows[i].Cells["name"].Value.ToString();
                            //    MessageBox.Show(header +":"+ i.ToString(), "Добавляем колонку:номер строки в prepare_data");
                            result.Columns.Add(header, header);
                        }

                        // MessageBox.Show("columns added");

                        while (SqlReader.Read())
                        {
                            result.Rows.Add();
                            for (int i = 0; i < SqlReader.FieldCount; i++)
                                result.Rows[row_number].Cells[i].Value = SqlReader.GetValue(i);
                            row_number++;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < SqlReader.FieldCount; i++)
                        {
                            header = SqlReader.GetName(i);
                            result.Columns.Add(header, header);
                        }

                        while (SqlReader.Read())
                        {
                            result.Rows.Add();
                            for (int j = 0; j < SqlReader.FieldCount; j++)
                                result.Rows[row_number].Cells[j].Value = SqlReader.GetValue(j);
                            row_number++;

                        }
                    }
                    
                }



            }

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.Source);
            }
            finally
            {
                if (SqlReader != null)
                    SqlReader.Close();
            }

           
            if (SqlReader != null)
                SqlReader.Close();

            Connections.CloseConnection(ConnectionID);

            return result;
        }

    }
}
