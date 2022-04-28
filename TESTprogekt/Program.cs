using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTprogekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainDir = @"C:\Test";
            string oldPath = @"C:\Test\Test1";
            string newPath = @"C:\Test\Test3\Test1";
            string fileName = "file.txt";
            string filePath = @"C:\Test\file.txt";
            string info;

            // MoveDirectory(oldPath, newPath);
           info =  CpFiles(oldPath, newPath);
            //info = DelFile(filePath);
            Console.WriteLine(info);

            Console.ReadKey(true);
        }    
         
        /// <summary>
        /// Перемещение каталога
        /// </summary>
        /// <param name="oldPath"></param>
        /// <param name="newPath"></param>
        /// <returns></returns>
        public static string MoveDirectory(string oldPath, string newPath)
        {
            string message;
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && Directory.Exists(newPath))
            {
                dirInfo.MoveTo(newPath);
                message = "Каталог перемещён";
            }
            else
                message = "Каталог не существует";

            return message;
        }

        /// <summary>
        /// Удаление каталога
        /// </summary>
        /// <param name="dirName"></param>
        /// <returns></returns>
        public static string DelDirectory(string dirName)
        {
            string message;
            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (dirInfo.Exists)
            {
                dirInfo.Delete(true);
                message ="Каталог удален";
            }
            else
            
            message = "Каталог не существует";

            return message;
        } 
        
        /// <summary>
        /// Копирование файлa
        /// </summary>
        /// <param name="path">Отсюда</param>
        /// <param name="nPath">Сюда</param>
       public static string CpFiles(string path, string nPath)
       {
            string message;
            FileInfo fileInf = new FileInfo(path);
          if (fileInf.Exists)
          {
              File.Copy(path, nPath, true);
              message = "Файл скопирован";
          }
          else
               message = "Файл не существует";

            return message;
       }

        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string DelFile(string filePath)
        {
            string message;
            
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                message = "Файл успешно удален!";
            }
            else
                message = "Файл не существует";

            return message;

        }
        
    }
}
