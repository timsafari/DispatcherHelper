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
    }
}
