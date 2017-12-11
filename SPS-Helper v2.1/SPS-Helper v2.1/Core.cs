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
            object[] CoreCommands = new object[scripts_subdir_count];
            SQLCommand[] SQLCommands = new SQLCommand[sqlcommand_count];
            MDXCommand[] MDXCommands = new MDXCommand[mdxcommand_count];
            PowerShellCommand[] PSCommands = new PowerShellCommand[pscommand_count];
            MenuCommand[] MenuCommands = new MenuCommand[menu_command_count];

            Initialized = 1;
           

        }

        static int GetCoreDirectories(out List<string> CoreDirs)
        {
            int result = 0;
            CoreDirs = new List<string>();

            try
            {
                CoreDirs.Add(Properties.Resources.Core_Menu_Files_Subdir);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_Menu_Files_Subdir", e.Message };
                Errors.ShowByCode(result, args );
            }
            try
            {
                CoreDirs.Add(Properties.Resources.Core_SQL_Files_Subdir);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_SQL_Files_Subdir", e.Message };                
                Errors.ShowByCode(result, args);
            }

            try
            {
                CoreDirs.Add(Properties.Resources.Core_PS_Files_Subdir);
            }
            catch (Exception e)
            {
                result = -21;
                object[] args = new object[2] { "Core_PS_Files_Subdir", e.Message };                
                Errors.ShowByCode(result, args);
            }

            try
            {

                CoreDirs.Add(Properties.Resources.Core_MDX_Files_Subdir);
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

            foreach (string folder in CoreDirs)
            {
                WorkingPath = AppContext.BaseDirectory;

                switch (folder)
                {
                    case "Core_Menu_Files_Subdir":
                        Ext = Properties.Resources.List_menu_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + folder, Ext, out menu_command_count);                        
                        break;

                    case "Core_SQL_Files_Subdir":
                        Ext = Properties.Resources.List_sql_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + folder, Ext, out sqlcommand_count);
                        break;

                    case "Core_PS_Files_Subdir":
                        Ext = Properties.Resources.List_ps_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + folder, Ext, out pscommand_count);
                        break;
                    case "Core_MDX_Files_Subdir":
                        Ext = Properties.Resources.List_mdx_ext;
                        result = fw.CountFilesInDirByExt(WorkingPath + folder, Ext, out mdxcommand_count);
                        break;
                }

                //System.Windows.Forms.MessageBox.Show(WorkingPath + folder);


            }

            return result;
        }
    }


}
