using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SPS_Helper
{
    class FileWorker
    {
        public int Read(string Path, out string TextData)
        {
            int result = 0;
            TextData = "";

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
                result = -1;
                return result;
            }

            //Ининциализация необходимых переменных
            byte[] bytes = new byte[command_file.Length];
            int numBytesToRead = (int)command_file.Length;
            

            while (numBytesToRead > 0)
            {
                try
                {
                    fact_bytes = command_file.Read(bytes, position, numBytesToRead);
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show(Path, "Ошибка чтения из файла");
                }
                if (fact_bytes == 0)
                    break;

                TextData = TextData + System.Text.Encoding.GetEncoding(1251).GetString(bytes);
                position += fact_bytes;
                numBytesToRead -= fact_bytes;
            }

            command_file.Close();

            return result;
        }

       public int CountFilesInDirByExt(string Folder, string ExtList, out int FileCount)
        {
            int result = 0;
            string path = Folder;
            
            FileCount = 0;

            if (!path.Contains(":\\"))
            {
                path = path + Directory.GetCurrentDirectory();
            }

            try
            {
                string[] files = Directory.GetFiles(path);
                string ext="";
                 foreach(string file in files)
                  {
                      ext = Path.GetExtention(file));
                      if (ExtList.Contains(ext))
                        {
                          result++;
                        }
                  }
            }
            catch
            {
                Error.ShowById(1);
                return result;
            }
            
            
            FileCount = result;
            
            result = 0;
            
            return result;
        }
    }
}
