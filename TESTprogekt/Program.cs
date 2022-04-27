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

            MoveDirectory();
        }    
         
        /// <summary>
        /// Перемещение каталога
        /// </summary>

        public static void MoveDirectory()
        {

            string oldPath = @"C:\Users\Desktop\repo\";
            string newPath = @"C:\SomeDir";
            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
            if (dirInfo.Exists && !Directory.Exists(newPath))
            {
                dirInfo.MoveTo(newPath);
            }

            Console.ReadKey();

        }

        /// <summary>
        /// Удаление каталога.
        /// </summary>
        public static void DelDirectory()
        {
            string dirName = @"C:\SomeDir";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            if (dirInfo.Exists)
            {
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            else
            {
                Console.WriteLine("Каталог не существует");
            }
        } 
        
        /// <summary>
        /// Копирование файлов
        /// </summary>
        /// <param name="path">Отсюда</param>
        /// <param name="nPath">Сюда</param>
       public static void CpFiles(string path, string nPath)
       {
           FileInfo fileInf = new FileInfo(path);
          if (fileInf.Exists)
          {
            File.Copy(path, nPath, true);
          }
          else
          {
             Console.WriteLine("Файл не существует");
          }
            
       }

        /// <summary>
        /// Удаление файлов
        /// </summary>
        public static void DelFiles()
        {
            if (File.Exists(@"C:\Users\Desktop\repo\"))
                
            {
                try
                {
                    File.Delete(@"C:\Users\Desktop\repo\file.txt");
                }
                catch(System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            
            }
        }
    }
}
