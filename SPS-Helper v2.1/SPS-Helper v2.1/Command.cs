using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.SqlServer.Server;
using System.IO;


namespace SPS_Helper_v2._1
{
    class Command
    {
        string Alias;
        string Type { get; }
        string Text;
        //int Buffer_size_in_bytes { get; set; }
        string[] Parameters;
        object[] ParameterValues;
 

        public int Load(string Path)        
        {
            int result = 0;
            //Buffer_size_in_bytes = 1024;
            
            int position = 0;
            int fact_bytes = 0;

            FileStream command_file = null;
            try
            {
                command_file = new FileStream(Path, FileMode.Open);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(Path, "Ошибка загрузки файла команды");
            }
            
            //Ининциализация необходимых переменных
            byte[] bytes = new byte[command_file.Length];
            int numBytesToRead = (int)command_file.Length;
            Text = "";

            while (numBytesToRead > 0)
            {
                try
                {
                    fact_bytes = command_file.Read(bytes, position, numBytesToRead);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(Path,"Ошибка чтения из файла");
                }
                if (fact_bytes == 0)
                    break;

                Text = Text + System.Text.Encoding.GetEncoding(1251).GetString(bytes);
                position += fact_bytes;
                numBytesToRead -= fact_bytes;
            }

            command_file.Close();

            System.Windows.Forms.MessageBox.Show(Text,"Команда считана");
            
            return result;
        }
        public int Save(string Path) {int result = 0; return result; }
        virtual public int Execute() {int result = 0; return result; }
    }

    class SQLCommand: Command
    {
        string Type = "SQL";
        public string ConnectionString;
        override public int Execute() { int result = 0; return result; }     
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
