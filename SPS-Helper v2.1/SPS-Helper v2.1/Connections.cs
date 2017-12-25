using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SPS_Helper
{
    public static class Connections
    {

        private static List <SqlConnection> sqlconnections = new List<SqlConnection>();

        public static List<string> sql_connectionstrings = new List<string>();
        public static List<string> mdx_connectionstrings = new List<string>();

        public static int CountOpened()
        {
            int result = 0;
            try
            {
                result = sqlconnections.Count;
            }
            catch
            {
                result = -1;
            }
            return result;
            }

        public static int OpenConnection/*Async*/(string ConnString, bool Force = false)
        {
            int result = 0;

            /*
             * if Force = 0, then try to find already opened connections 
             */
            if (Force == false && sqlconnections != null)
            {
                for(int i=0;i < sqlconnections.Count;i++)
                {
                    if (sqlconnections[i].ConnectionString == ConnString && sqlconnections[i].State.ToString() != "Closed")
                    {
                        result = i;
                        return result;
                    }

                }
            }
            try
            {
                SqlConnection new_connection = new SqlConnection();            
                new_connection.ConnectionString = ConnString;                
                sqlconnections.Add(new_connection);
                new_connection.Open/*Async*/();
                result = sqlconnections.Count - 1;
            }
            catch
            {
                result = -1;
            }         
            return result;
        }

        public static int CloseConnection(int ConnID)
        {
            int result = 0;

            if (sqlconnections.Count > ConnID)
            {
                if (sqlconnections[ConnID].State.ToString() == "Open")
                    sqlconnections[ConnID].Close();
                else result = -2;
            }

            return result;
        }

        public static int CloseAllConnections()
        {
            int result = 0;
            foreach (SqlConnection conn in sqlconnections)
            {
                CloseConnection(sqlconnections.IndexOf(conn));
            }
            return result;
        }

        public static SqlConnection GetConnection(int ConnID)
        {
            SqlConnection result = null;
            try
            {
                result = sqlconnections[ConnID];
            }
            catch
            {

            }
            return result;
        }

        public static int LoadConnectionStrings()
        {
            int result = 0;

            

            return result;
        }
    }
}
