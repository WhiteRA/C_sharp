﻿namespace FileManager
{
    public class Program
    {

        /*Реализовать простейший файловый менеджер с использованием ООП (классы, наследование и прочее).
### Файловый менеджер должен иметь возможность:
* показывать содержимое дисков;
* создавать папки/файлы;
* удалять папки/файлы;
* переименовывать папки/файлы;
* копировать/переносить папки/файлы;
* вычислять размер папки/файла;
* производить поиск по маске (с поиском по подпапкам);
* для текстовых файлов готовить статические данные (кол-во слов, кол-во строк, кол-во абзацев, кол-во символов с пробелами, кол-во слов без пробелов).

Предусмотреть возможность изменения атрибутов файлов.*/



        public static void Main(string[] args)
        {
            var console_ui = new ConsoleUserInterface();
            FileManager a = new FileManager(console_ui);
            a.Start();
            
            
        }
       
    }
}
