using System;
using System.IO;
using System.IO.Pipes;
using New_library;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\zapev\\OneDrive\\Рабочий стол\\testfile.txt";
            string content = "Hello, World!";

            try
            {
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                Console.WriteLine("Запись в файл...");
                FileManager.WriteToFile(filePath, content);
                Console.WriteLine("Запись завершена.");

                string result = FileManager.ReadFromFile(filePath);
                Console.WriteLine("Прочитано из файла: " + result);

                Console.WriteLine("Демонстрация checked и unchecked исключений...");
                FileManager.DemonstrateCheckedUncheckedExceptions();
                Console.WriteLine("Демонстрация завершена.");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден: " + ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
            finally
            {
                FileStream fileStream = null;
                if (fileStream != null)
                {
                    fileStream.Close();
                }
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}