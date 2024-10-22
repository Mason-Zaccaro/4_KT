using System;
using System.IO;

namespace New_library
{
    public class FileManager
    {
        public static void WriteToFile(string filePath, string content)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, false);
                writer.Write(content);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Ошибка доступа: " + ex.Message);
                throw;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка ввода-вывода: " + ex.Message);
                throw;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static string ReadFromFile(string filePath)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                return reader.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден: " + ex.Message);
                throw;
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка ввода-вывода: " + ex.Message);
                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public static void Demonstrate_IOExceptions()
        {
            try
            {
                using (FileStream fs = new FileStream("nonexistentfile.txt", FileMode.Open))
                {
                    
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Checked исключение: " + ex.Message);
            }

            try
            {
                string nullString = null;
                int length = nullString.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Unchecked исключение: " + ex.Message);
            }
        }
    }
}