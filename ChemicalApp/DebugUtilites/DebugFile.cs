using System;
using System.IO;
<<<<<<< HEAD
using ChemicalFormulas;
=======

>>>>>>> main

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
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Файл не удалось создать");
            }
        }
        public void WriteDebugFile(string path, string text)
        {
            if (text != null)
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLineAsync(text);
                streamWriter.Close();
            }
            else
            {
               
            }
        }
    }
    public class FileReader
    {
        public void AddTextInFile(string text)
        {
            string path = @"C:\Users\Пользователь\OneDrive\Рабочий стол\ChemicalLibrary\debug.txt";
            DebugFile df = new DebugFile();
            df.WriteDebugFile(path, text);
        }
    }
    public class DebugFileBoolean
    {
        public bool isDebugFileConnect() { return true; }
    }

}
