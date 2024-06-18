using FileManager.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Commands
{
    public class ListDriversCommand : FileManagerComands
    {
        private readonly IUserInterface _userInterface;
        
        public ListDriversCommand(IUserInterface userInterface) => _userInterface = userInterface;


        public override void Execute(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            _userInterface.WriteText($"Используются следующие диски: {drives.Length} ");
            foreach (var drive in drives)
            {
                _userInterface.WriteText($"    {drive.Name}");
            }
        }
    }
}
