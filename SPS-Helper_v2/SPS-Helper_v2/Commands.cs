using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SPS_Helper_v2
{
    class Command
    {
        public string Text;
        public string Type;
        public string Parameters;
        public void Load(string Path){ }
        public int Execute() { int result = 0; return result; }

    }

    class SQLCommand:Command
    {
        public string ConnectionString;
        public new string Type = "SQL";        
        public string[][] clickable_columns;//массив для указания колонок и скрипта, который запустить с ними как с параметрами       
        private static DataGridView columns() { DataGridView result = null; return result; }
    }

    class MenuCommand:Command
    {
        public int Id = 1 ;
        public int ParentID = 0;
        public string Action = "";
        public new string Type = "Menu";
    }

    class PowerShellCommand : Command
    {
        public int Id = 1;
        public int ParentID = 0;
        public string Action = "";
        public new string Type = "PowerShell";
    }
}
