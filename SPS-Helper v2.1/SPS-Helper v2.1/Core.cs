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
       public static int Initialized = 0;
       static List<string> CoreDirs = null;

        public static void Initialize()
        {
            int scripts_subdir_count = 0;
            int sqlcommand_count = 0;
            int mdxcommand_count = 0;
            int pscommand_count = 0;
            int menu_command_count = 0;
            

            Errors.Initialize();
            GetCoreDirectories(out CoreDirs);
            
           
                    
              
              

            /*
             * scripts_subdir_count = количество непустых субдиректорий со скриптами
             * sqlcommand_count,mdxcommand_count,pscommand_count,menu_command_count - количество скриптов соотв.типа
             */
            object[] CoreCommands = new object[scripts_subdir_count];
            SQLCommand[] SQLCommands = new SQLCommand[sqlcommand_count];
            MDXCommand[] MDXCommands = new MDXCommand[mdxcommand_count];
            PowerShellCommand[] PSCommands = new PowerShellCommand[pscommand_count];
            MenuCommand[] MenuCommands = new MenuCommand[menu_command_count];

            Initialized = 1;

        }

        static void GetCoreDirectories(out List<string> CoreDirs)
        {
            CoreDirs = null;
            try
            {
                CoreDirs.Add(Properties.Resources.Core_Menu_Files_Subdir);            
            }
            catch (Exception e)
            {
                object[] args = new object[2] { "Core_Menu_Files_Subdir", e.Message };
                Errors.ShowByCode(-21, args );
            }
            try
            {
                CoreDirs.Add(Properties.Resources.Core_SQL_Files_Subdir);

            }
            catch (Exception e)
            {
                object[] args = new object[2] { "Core_SQL_Files_Subdir", e.Message };
                Errors.ShowByCode(-21, args);
            }
            try
            {
                CoreDirs.Add(Properties.Resources.Core_PS_Files_Subdir);
            }
            catch (Exception e)
            {
                object[] args = new object[2] { "Core_PS_Files_Subdir", e.Message };
                Errors.ShowByCode(-21, args);
            }
            try
            {

                CoreDirs.Add(Properties.Resources.Core_MDX_Files_Subdir);
            }
            catch (Exception e)
            {
                object[] args = new object[2] { "Core_MDX_Files_Subdir", e.Message };
                Errors.ShowByCode(-21, args);
            }

        }
        
        
        static int CountCommands()
        {
            int result = 0;
            int counter = 0;
            string WorkingPath = Properties.Directory;
           
            foreach(string folder in CoreDirs)
              {
                try
                {
                  result = CountFilesInDir(WorkingPath + folder, out counter);
                }
                catch
                {
                  Error.ShowById(result);
                  return result;
                }
                switch (folder)
                {
                    case "Core_Menu_Files_Subdir":
                      menu_command_count = counter;
                    break;
                    case "Core_SQL_Files_Subdir":
                      sqlcommand_count = counter;
                    break;
                    case "Core_PS_Files_Subdir":
                      pscommand_count = counter;
                    break;
                    case "Core_MDX_Files_Subdir":
                      mdxcommand_count = counter;
                    
                    break;
                }
        }
    }


}
