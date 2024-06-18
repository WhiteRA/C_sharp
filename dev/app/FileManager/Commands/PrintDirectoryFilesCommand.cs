using FileManager.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Commands
{
    public class PrintDirectoryFilesCommand : FileManagerComands
    {
        private readonly IUserInterface _userInterface;
        private readonly FileManager _fileManager;

        public PrintDirectoryFilesCommand(IUserInterface UserInterface, FileManager FileManager)
        {
            _userInterface = UserInterface;
            _fileManager = FileManager;
        }
        public override void Execute(string[] args)
        {
            var directory = _fileManager.CurrentDirectory;
            _userInterface.WriteText($"Содержимое дерриктории {directory}:");

            long total_ength_file = 0;
            int dir_count = 0;
            foreach (var sub_dir in directory.EnumerateDirectories())
            {
                _userInterface.WriteText($"    d    {sub_dir.Name}");
                dir_count++;
            }

            int file_count = 0;
            foreach (var file in directory.EnumerateFiles())
            {
                _userInterface.WriteText($"    f    {file.Name}");
                file_count++;
                total_ength_file += file.Length;
            }

            _userInterface.WriteText($"Директорий {dir_count} / Файлов {file_count} (суммарный размер {total_ength_file})" );


        }
    }
}
