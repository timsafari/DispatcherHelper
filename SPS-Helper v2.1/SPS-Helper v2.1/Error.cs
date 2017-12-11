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
            Error[6].Subsection = "Файлы ядра";
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

            /*
             * Ресурсы
             */
            Error[11].Code = -21;
            Error[11].Section = (int)Sections.Core;
            Error[11].Subsection = "Пути";
            Error[11].Header = "Ошибка доступа к значениям ресурсов";
            Error[11].Description = "Не удается прочитать значение ресурса {{0}}, ошибка {{1}}";

            /*
             *  Ошибки
             */
            Error[12].Code = -404;
            Error[12].Section = (int)Sections.Core;
            Error[12].Subsection = "Ошибки";
            Error[12].Header = "Ошибка доступа к сведениям об ошибке";
            Error[12].Description = "Нет описания для ошибки с кодом: {{0}}";
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

            try
            {
                header = Error[Error_id].Header;
                message = Error[Error_id].Description;
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
