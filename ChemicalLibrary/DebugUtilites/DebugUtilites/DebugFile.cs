using System;
using System.IO;

namespace DebugUtilites
{
    public class DebugFile
    {
        public void CreateDirectiory(string path)
        {
            try
            {
                FileInfo FileIn = new FileInfo(path);
                if (!FileIn.Exists)
                {
                    FileIn.Create();
                }
            }
            catch
            {
                Console.WriteLine("Файл не удалось создать");
            }
        }
        public void WriteDebugFile(string path, string text)
        {
            try
            {
                File.AppendAllText(path, "\n"+text);
            }
            catch(Exception ex)
            {

            }
        }
    }
    public class FileWriter
    {
        public void AddTextInFile(string text)
        {
            string path = @"C:\Users\Пользователь\OneDrive\Рабочий стол\ChemicalLibrary\ChemicalLibrary\debug.txt";
            DebugFile debug = new DebugFile();
            debug.WriteDebugFile(path, text);
        }
        
        
    }
}
