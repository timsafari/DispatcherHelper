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

       static string[,] CoreDirs;

       static int scripts_subdir_count = 0;
       static int sqlcommand_count = 0;
       static int mdxcommand_count = 0;
       static int pscommand_count = 0;
       static int menu_command_count = 0;

        public static void Initialize()
        {
            int result = 0;
            
            

            Errors.Initialize();
            result = GetCoreDirectories(out CoreDirs);

            if (result != 0)
            {
                Environment.Exit(result);
            }

            CountCommands();
            /*
             * scripts_subdir_count = количество непустых субдиректорий со скриптами
             * sqlcommand_count,mdxcommand_count,pscommand_count,menu_command_count - количество скриптов соотв.типа
             */


            System.Windows.Forms.MessageBox.Show(menu_command_count.ToString());

            object[] CoreCommands = new object[scripts_subdir_count];
            SQLCommand[] SQLCommands = new SQLCommand[sqlcommand_count];
            MDXCommand[] MDXCommands = new MDXCommand[mdxcommand_count];
            PowerShellCommand[] PSCommands = new PowerShellCommand[pscommand_count];
            MenuCommand[] MenuCommands = new MenuCommand[menu_command_count];

            Initialized = 1;
           

        }

        static int GetCoreDirectories(out string[,] CoreDirs)
        {
            int result = 0;

            CoreDirs = new string[4,2];

            try
            {
                CoreDirs.SetValue("Core_Menu_Files_Subdir",0,0);
                CoreDirs.SetValue(Properties.Resources.Core_SQL_Files_Subdir,0,1);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_Menu_Files_Subdir", e.Message };
                Errors.ShowByCode(result, args );
            }

            try
            {
                CoreDirs.SetValue("Core_SQL_Files_Subdir",1, 0);
                CoreDirs.SetValue(Properties.Resources.Core_SQL_Files_Subdir,1, 1);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_SQL_Files_Subdir", e.Message };                
                Errors.ShowByCode(result, args);
            }

            try
            {
                CoreDirs.SetValue("Core_PS_Files_Subdir",2, 0);
                CoreDirs.SetValue(Properties.Resources.Core_SQL_Files_Subdir,2, 1);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_PS_Files_Subdir", e.Message };                
                Errors.ShowByCode(result, args);
            }

            try
            {
                CoreDirs.SetValue("Core_MDX_Files_Subdir",3, 0);
                CoreDirs.SetValue(Properties.Resources.Core_MDX_Files_Subdir,3, 1);                
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_MDX_Files_Subdir", e.Message };
                Errors.ShowByCode(result, args);
            }

            return result;

        }


        static int CountCommands()
        {
            int result = 0;

            string WorkingPath = "";
            string Ext = "";
            FileWorker fw = new FileWorker();

            for(int i = 0; i < 4; i++)
         //       for (int j = 0; j < 2; j++) 
            {
                WorkingPath = AppContext.BaseDirectory;

                switch (CoreDirs.GetValue(i, 0).ToString())
                {
                    case "Core_Menu_Files_Subdir":
                        Ext = Properties.Resources.List_menu_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + CoreDirs.GetValue(i, 1).ToString(), Ext, out menu_command_count);                        
                        break;

                    case "Core_SQL_Files_Subdir":
                        Ext = Properties.Resources.List_sql_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + CoreDirs.GetValue(i, 1), Ext, out sqlcommand_count);
                        break;

                    case "Core_PS_Files_Subdir":
                        Ext = Properties.Resources.List_ps_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + CoreDirs.GetValue(i, 1), Ext, out pscommand_count);
                        break;
                    case "Core_MDX_Files_Subdir":
                        Ext = Properties.Resources.List_mdx_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + CoreDirs.GetValue(i, 1), Ext, out mdxcommand_count);
                        break;
                }

                //System.Windows.Forms.MessageBox.Show(WorkingPath + folder);


            }

            return result;
        }
    }


}
