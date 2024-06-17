﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class FileManager : IFileManager
    {
        private readonly IUserInterface _UserInterface;
        public FileManager(IUserInterface UserInterface) 
        { 
            _UserInterface = UserInterface;
        }

        public void Start()
        {
            _UserInterface.WriteText("НАЧАЛО");
            bool work = true;
            do
            {
                var input = _UserInterface.ReadText("> ", false);
                if (input == "quit")
                {
                    work = false;
                    Console.WriteLine("КОНЕЦ");
                }
                else
                {
                    _UserInterface.WriteText($"Введено - {input}");
                }
            } while (work);
        }









        public void Copy(string pathFrom, string pathWhere, string nameFileToCopy)
        {
            throw new NotImplementedException();
        }

        public void Create(string path, string name)
        {
            throw new NotImplementedException();
        }

        public void Delete(string path, string name)
        {
            throw new NotImplementedException();
        }

        public void ReadTextFile()
        {
            throw new NotImplementedException();
        }

        public void Rename(string path, string name)
        {
            throw new NotImplementedException();
        }

        public void Search(string name)
        {
            throw new NotImplementedException();
        }

        public void Show(string path)
        {
            throw new NotImplementedException();
        }

        public void Size()
        {
            throw new NotImplementedException();
        }

        public void Transfer(string pathFrom, string pathWhere, string nameFileToTransfer)
        {
            throw new NotImplementedException();
        }
    }
}
