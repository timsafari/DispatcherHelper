﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.SqlServer.Server;



namespace SPS_Helper
{
    class Command
    {
        string Alias;
        string Type { get; }
        public string Text;
        //int Buffer_size_in_bytes { get; set; }
        string[] Parameters;
        object[] ParameterValues;
 

        public int Load(string Path)        
        {
            int result = 0;

            FileWorker fw = new FileWorker();

            result = fw.Read(Path,out Text);

            System.Windows.Forms.MessageBox.Show(Text,"Команда считана");
            
            return result;
        }
        public int Save(string Path) {int result = 0; return result; }
        virtual public int Execute() {int result = 0; return result; }
    }

    class SQLCommand: Command
    {
        string Type = "SQL";
        string ConnectionString;
        
        override public int Execute() 
        { 
          int result = 0; 
          
          int ConnectionId = 0;
          SqlDataReader SqlReader = null;
          SqlCommand command = new SqlCommand(Text);

            ConnectionId = Connections.OpenConnection(ConnectionString);
            command.Connection = Connections.GetConnection(ConnectionId);

            try
            {
                SqlReader = command.ExecuteReader();

                if (SqlReader.HasRows)
                {
                    for (int i = 0; i < SqlReader.FieldCount; i++)
                    {
                        //считываем сведения о столбцах
                        SqlReader.GetName(i);
                    }

                    while (SqlReader.Read())
                    {
                        for (int j = 0; j < SqlReader.FieldCount; j++)
                        {
                            // считываем данные построчно
                            SqlReader.GetValue(j);
                        }
                    }
                }
            }

            catch
            {

            } 

          return result; 
        }     
    }

    class MenuCommand : Command
    {
        public int Id = 1;
        public int ParentID = 0;
        public string ActionType = "";
        public string Action = "";
        public string Type = "Menu";
    }

    class PowerShellCommand : Command
    {
        public string Type = "PowerShell";
    }

    class MDXCommand : Command
    {
        public string Type = "MDX";
  
    }
}
