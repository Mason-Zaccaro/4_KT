namespace New_library
{
    public class FileManager
    {
        public static void WriteToFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }

        public static string ReadFromFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
