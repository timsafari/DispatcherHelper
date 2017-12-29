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

            FileStream txt_file = null;
            try
            {
                txt_file = new FileStream(Path, FileMode.Open);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(Path, "Ошибка загрузки файла команды");
                result = -1;
                return result;
            }

            //Ининциализация необходимых переменных
            byte[] bytes = new byte[txt_file.Length];
            int numBytesToRead = (int)txt_file.Length;


            while (numBytesToRead > 0)
            {
                try
                {
                    fact_bytes = txt_file.Read(bytes, position, numBytesToRead);
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

            txt_file.Close();

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

            //System.Windows.Forms.MessageBox.Show("в папке: \n" + path, "Ищем расширение: " + ExtList);

            try
            {
                string[] files = Directory.GetFiles(path);

                string ext = "";

                foreach (string file in files)
                {
                    ext = Path.GetExtension(file);
                    if (ExtList.Contains(ext))
                    {
                        FileCount++;
                    }
                }
            }
            catch
            {
                result = -1;

                object[] args = new object[1];
                args[0] = path;

                Errors.ShowByID(1, args);
                return result;
            }

            return result;
        }

        public int Write(string TextData, string Path)
        {
            int result = 0;

            FileStream txt_file = null;

            try
            {
                txt_file = new FileStream(Path, FileMode.CreateNew);
            }
            catch (Exception e)
            {
                object[] args = new object[1];
                args[0] = e.Message;

                result = -6;

                System.Windows.Forms.DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = Errors.ShowByCode_Dialog(result, args, System.Windows.Forms.MessageBoxButtons.OKCancel);

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        txt_file = new FileStream(Path, FileMode.CreateNew);
                    }
                    catch (Exception e2)
                    {
                        result = -7;
                        object[] args2 = new object[1];
                        args2[0] = e2.Message;
                        Errors.ShowByCode(result, args2);
                        return result;
                    }
                }

                return result;
            }


            try
            {
                txt_file.Write(System.Text.Encoding.GetEncoding(1251).GetBytes(TextData), 0, System.Text.Encoding.GetEncoding(1251).GetByteCount(TextData));
            }
            catch (Exception e3)
            {
                result = -8;
                object[] args = new object[1];
                args[0] = e3.Message;
                Errors.ShowByCode(result, args);
                return result;
            }

            return result;
        }
    }
}
