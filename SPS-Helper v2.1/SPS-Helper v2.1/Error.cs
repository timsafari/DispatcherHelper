using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPS_Helper
{
    public static class Errors
    {
        public enum Sections:int { Any, Files, Connections, Commands };

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
            Error[1].Description = "Отсутствует директория или путь некорректен {1}";

            Error[2].Code = -2;
            Error[2].Section = (int)Sections.Files;
            Error[2].Subsection = "Файлы ядра";
            Error[2].Header = "Ошибка доступа к файлу";
            Error[2].Description = "Не удается открыть для чтения файл {1}, ошибка {2}";

            Error[3].Code = -3;
            Error[3].Section = (int)Sections.Files;
            Error[3].Subsection = "Файлы ядра";
            Error[3].Header = "Ошибка доступа к файлу";
            Error[3].Description = "Не удается открыть для записи файл {1}, ошибка {2}";

            Error[4].Code = -3;
            Error[4].Section = (int)Sections.Files;
            Error[4].Subsection = "Файлы ядра";
            Error[4].Header = "Ошибка доступа к файлу";
            Error[4].Description = "Не удается прочитать данные из файла {1}, ошибка {2}";

            Error[5].Code = -5;
            Error[5].Section = (int)Sections.Files;
            Error[5].Subsection = "Файлы ядра";
            Error[5].Header = "Ошибка доступа к файлу";
            Error[5].Description = "Не удается закрыть файл {1}, ошибка {2}";

            //Пользовательские файлы
            //Ядро
            Error[6].Code = -1;
            Error[6].Section = (int)Sections.Files;
            Error[6].Subsection = "Файлы ядра";
            Error[6].Header = "Ошибка доступа к файлу";
            Error[6].Description = "Отсутствует директория или путь некорректен {1}";

            Error[7].Code = -2;
            Error[7].Section = (int)Sections.Files;
            Error[7].Subsection = "Пользовательские файлы";
            Error[7].Header = "Ошибка доступа к файлу";
            Error[7].Description = "Не удается открыть для чтения файл {1}, ошибка {2}";

            Error[8].Code = -3;
            Error[8].Section = (int)Sections.Files;
            Error[8].Subsection = "Пользовательские файлы";
            Error[8].Header = "Ошибка доступа к файлу";
            Error[8].Description = "Не удается открыть для записи файл {1}, ошибка {2}";

            Error[9].Code = -4;
            Error[9].Section = (int)Sections.Files;
            Error[9].Subsection = "Пользовательские файлы";
            Error[9].Header = "Ошибка доступа к файлу";
            Error[9].Description = "Не удается прочитать данные из файла {1}, ошибка {2}";

            Error[10].Code = -5;
            Error[10].Section = (int)Sections.Files;
            Error[10].Subsection = "Пользовательские файлы";
            Error[10].Header = "Ошибка доступа к файлу";
            Error[10].Description = "Не удается закрыть файл {1}, ошибка {2}";
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
