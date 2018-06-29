using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Helper
{
    public static class Errors
    {
        public enum Sections:int { Any, Core, Files, Connections, Commands };

        public struct ErrorInfo
        {
            public int Code;
            public int Section;
            public string Subsection;
            public string Header;
            public string Description;
        }

        public static ErrorInfo[] Error = new ErrorInfo[20];
        public static void Initialize()
        {
            Error[0].Code = 0;
            Error[0].Section = (int)Sections.Any;
            Error[0].Subsection = "Any";
            Error[0].Header = "Ошибки нет";
            Error[0].Description = "Операция произведена успешно";
            /*
             * Файлы
             */

            //Ядро
            Error[1].Code = -1;
            Error[1].Section = (int)Sections.Files;
            Error[1].Subsection = "Файлы ядра";
            Error[1].Header = "Ошибка доступа к файлу";
            Error[1].Description = "Отсутствует директория или путь {{0}} некорректен";

            Error[2].Code = -2;
            Error[2].Section = (int)Sections.Files;
            Error[2].Subsection = "Файлы ядра";
            Error[2].Header = "Ошибка доступа к файлу";
            Error[2].Description = "Не удается открыть для чтения файл {{0}}, ошибка {{1}}";

            Error[3].Code = -3;
            Error[3].Section = (int)Sections.Files;
            Error[3].Subsection = "Файлы ядра";
            Error[3].Header = "Ошибка доступа к файлу";
            Error[3].Description = "Не удается открыть для записи файл {{0}}, ошибка {{1}}";

            Error[4].Code = -3;
            Error[4].Section = (int)Sections.Files;
            Error[4].Subsection = "Файлы ядра";
            Error[4].Header = "Ошибка доступа к файлу";
            Error[4].Description = "Не удается прочитать данные из файла {{0}}, ошибка {{1}}";

            Error[5].Code = -5;
            Error[5].Section = (int)Sections.Files;
            Error[5].Subsection = "Файлы ядра";
            Error[5].Header = "Ошибка доступа к файлу";
            Error[5].Description = "Не удается закрыть файл {{0}}, ошибка {{1}}";

            //Пользовательские файлы
            Error[6].Code = -1;
            Error[6].Section = (int)Sections.Files;
            Error[6].Subsection = "Пользовательские файлы";
            Error[6].Header = "Ошибка доступа к файлу";
            Error[6].Description = "Отсутствует директория или путь некорректен {{0}}";

            Error[7].Code = -2;
            Error[7].Section = (int)Sections.Files;
            Error[7].Subsection = "Пользовательские файлы";
            Error[7].Header = "Ошибка доступа к файлу";
            Error[7].Description = "Не удается открыть для чтения файл {{0}}, ошибка {{1}}";

            Error[8].Code = -3;
            Error[8].Section = (int)Sections.Files;
            Error[8].Subsection = "Пользовательские файлы";
            Error[8].Header = "Ошибка доступа к файлу";
            Error[8].Description = "Не удается открыть для записи файл {{0}}, ошибка {{1}}";

            Error[9].Code = -4;
            Error[9].Section = (int)Sections.Files;
            Error[9].Subsection = "Пользовательские файлы";
            Error[9].Header = "Ошибка доступа к файлу";
            Error[9].Description = "Не удается прочитать данные из файла {{0}}, ошибка {{1}}";

            Error[10].Code = -5;
            Error[10].Section = (int)Sections.Files;
            Error[10].Subsection = "Пользовательские файлы";
            Error[10].Header = "Ошибка доступа к файлу";
            Error[10].Description = "Не удается закрыть файл {{0}}, ошибка {{1}}";

            Error[11].Code = -6;
            Error[11].Section = (int)Sections.Files;
            Error[11].Subsection = "Пользовательские файлы";
            Error[11].Header = "Ошибка доступа к файлу";
            Error[11].Description = "Файл {{0}} уже существует, перезаписываем?";

            Error[12].Code = -7;
            Error[12].Section = (int)Sections.Files;
            Error[12].Subsection = "Пользовательские файлы";
            Error[12].Header = "Ошибка доступа к файлу";
            Error[12].Description = "Не удалось создать новый файл";

            Error[13].Code = -8;
            Error[13].Section = (int)Sections.Files;
            Error[13].Subsection = "Пользовательские файлы";
            Error[13].Header = "Ошибка доступа к файлу";
            Error[13].Description = "Не удалось произвести запись в файл {{0}}, Ошибка {{1}}";


            /*
             * Ресурсы
             */
            Error[14].Code = -21;
            Error[14].Section = (int)Sections.Core;
            Error[14].Subsection = "Пути";
            Error[14].Header = "Ошибка доступа к значениям ресурсов";
            Error[14].Description = "Не удается прочитать значение ресурса {{0}}, ошибка {{1}}";

            /*
             *  Ошибки
             */
            Error[15].Code = -404;
            Error[15].Section = (int)Sections.Core;
            Error[15].Subsection = "Ошибки";
            Error[15].Header = "Ошибка доступа к сведениям об ошибке";
            Error[15].Description = "Нет описания для ошибки с кодом: {{0}}";


            /*
             *  SQL
             */
            Error[16].Code = -500;
            Error[16].Section = (int)Sections.Commands;
            Error[16].Subsection = "Результат запроса";
            Error[16].Header = "Возвращен пустой результат";
            Error[16].Description = "Вероятно, это даже и не ошибка";

            Error[17].Code = -501;
            Error[17].Section = (int)Sections.Commands;
            Error[17].Subsection = "Результат запроса";
            Error[17].Header = "Ошибка считывания результата запроса";
            Error[17].Description = "Успели дойти до строки {{1}}";
        }
        public static void Log()
        {

        }
        public static void ShowByCode(int Error_code,object[] args = null)
        {
            string header = "";     //Заголовок MessageBox'а
            string message = "";    //Описание ошибки
            
            bool flag = false;            

            //Пытаемся найти ошибку по коду
            try
            {
                
                for (int i = 0; i < Error.Length;i++)
                {
                    if (Error[i].Code == Error_code)

                    {
                        header = Error[i].Header;
                        message = Error[i].Description;
                        flag = true;
                        //System.Windows.Forms.MessageBox.Show("flag==true", "try");
                        break;
                    }
                }                
            }
            catch
            {

            }

            //Если нашли
            if (flag == true)  
            {
                //Проверим аргументы и заменим
                if (args != null)
                {
                    string details = "";    //Очередной аргумент

                    int args_arg_count = args.Length;

                    for (int j = 0; j < args_arg_count; j++)
                    {
                        details = args[j].ToString();
                        message = message.Replace("{{" + j.ToString() + "}}", details);
                        
                    }
                    //System.Windows.Forms.MessageBox.Show("flag==true", "args");
                }
            }
            else //Если не нашли, выведем, что ошибка не найдена
            {
                try
                {
                    header = Error[12].Header;
                    message = Error[12].Description;
                }
                catch
                {
                    header = "Произошла какая-то ошибка";
                    message = "Нет описания для ошибки";
                }

                //И попытаемся указать описание, переданное системой
                if (args != null)
                    try
                    {
                        message = message.Replace("{{0}}", args[0].ToString());
                    }
                    catch
                    {

                    }
                else
                    message = "Нет описания для ошибки";
            }

            System.Windows.Forms.MessageBox.Show(message,header);
        }
        public static void ShowByID(int Error_id, object[] args = null)
        {
            string header = "";
            string message = "";
            string details = "";
            bool flag = false;

            
            int error_id_local = 0;

            error_id_local = System.Math.Abs(Error_id);

            try
            {
                header = Error[error_id_local].Header;
                message = Error[error_id_local].Description;
                flag = true;
  
            }
            catch
            {

            }

            if (flag == true)
            {

                if (args != null)
                {
                    int args_arg_count = args.Length;
                    for (int j = 0; j < args_arg_count; j++)
                    {
                        details = args[j].ToString();
                        message = message.Replace("{{" + j.ToString() + "}}", details);
                    }                    
                }
            }
            else
            {
                try
                {
                    header = Error[12].Header;
                    message = Error[12].Description;
                }
                catch
                {
                    header = "Произошла какая-то ошибка";
                    message = "Нет описания для ошибки";
                }

                if (args != null)
                    message = message.Replace("{{0}}", args[0].ToString());
                else
                    message = "Нет описания для ошибки";
            }

            System.Windows.Forms.MessageBox.Show(message, header);
        }
        public static System.Windows.Forms.DialogResult ShowByCode_Dialog(int Error_code, object[] args = null, System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OKCancel)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.None;

            string header = "";     //Заголовок MessageBox'а
            string message = "";    //Описание ошибки

            bool flag = false;

            //Пытаемся найти ошибку по коду
            try
            {

                for (int i = 0; i < Error.Length; i++)
                {
                    if (Error[i].Code == Error_code)

                    {
                        header = Error[i].Header;
                        message = Error[i].Description;
                        flag = true;
                        //System.Windows.Forms.MessageBox.Show("flag==true", "try");
                        break;
                    }
                }
            }
            catch
            {

            }

            //Если нашли
            if (flag == true)
            {
                //Проверим аргументы и заменим
                if (args != null)
                {
                    string details = "";    //Очередной аргумент

                    int args_arg_count = args.Length;

                    for (int j = 0; j < args_arg_count; j++)
                    {
                        details = args[j].ToString();
                        message = message.Replace("{{" + j.ToString() + "}}", details);

                    }
                    //System.Windows.Forms.MessageBox.Show("flag==true", "args");
                }
            }
            else //Если не нашли, выведем, что ошибка не найдена
            {
                try
                {
                    header = Error[12].Header;
                    message = Error[12].Description;
                }
                catch
                {
                    header = "Произошла какая-то ошибка";
                    message = "Нет описания для ошибки";
                }

                //И попытаемся указать описание, переданное системой
                if (args != null)
                    try
                    {
                        message = message.Replace("{{0}}", args[0].ToString());
                    }
                    catch
                    {

                    }
                else
                    message = "Нет описания для ошибки";
            }
            
            result = System.Windows.Forms.MessageBox.Show(message, header,buttons);
            return result;
        }
        
        /*
        // В порядке бреда
        List<List<List<List<string>>>> Errors = new List<List<List<List<string>>>>();

        private void Initialize()
        {
            Errors.Add("Any"{ "All"{ { } } });
            //myList.Add(new List<string> { "a", "b" });
        }
        */

    }
}
