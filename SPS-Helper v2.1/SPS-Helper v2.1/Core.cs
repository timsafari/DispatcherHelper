using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            //Надо для работы с ресурсами
using System.Reflection;    //Надо для работы с ресурсами


namespace SPS_Helper
{
    public static class Core
    {
       public static void Initialize()
        {
            int scripts_subdir_count = 0;
            int sqlcommand_count = 0;
            int mdxcommand_count = 0;
            int pscommand_count = 0;
            int menu_command_count = 0;

            /*
             * scripts_subdir_count = количество непустых субдиректорий со скриптами
             * sqlcommand_count,mdxcommand_count,pscommand_count,menu_command_count - количество скриптов соотв.типа
             */
            object[] CoreCommands = new object[scripts_subdir_count];
            SQLCommand[] SQLCommands = new SQLCommand[sqlcommand_count];
            MDXCommand[] MDXCommands = new MDXCommand[mdxcommand_count];
            PowerShellCommand[] PSCommands = new PowerShellCommand[pscommand_count];
            MenuCommand[] MenuCommands = new MenuCommand[menu_command_count];
            
            

        }
    }
}
