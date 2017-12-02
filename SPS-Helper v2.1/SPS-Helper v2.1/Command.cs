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
        string[] Parameters;
        object[] ParameterValues;
        public int Load(string Path)
        {
            int result = 0;

            FileStream command_file = new FileStream(Path, FileMode.Open);
            
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
