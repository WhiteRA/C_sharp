using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class ConsoleFileInterface : IFileManager
    {
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
