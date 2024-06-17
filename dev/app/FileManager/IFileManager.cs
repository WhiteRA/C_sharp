using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public interface IFileManager
    {
        void Show(string path); // TODO : показать содержимое папки
        void Create(string path, string name); // TODO : Создать
        void Delete(string path, string name); // TODO : удалить
        void Rename(string path, string name); // TODO : переименовать
        void Copy(string pathFrom, string pathWhere, string nameFileToCopy); // TODO : копировать
        void Transfer(string pathFrom, string pathWhere, string nameFileToTransfer); // TODO : перенос
        void Size(); // TODO : определение размера. Надо докидать перегрузок
        void Search(string name); // TODO : поиск файла
        void ReadTextFile(); // TODO : чтение текстового фала
    }
}
