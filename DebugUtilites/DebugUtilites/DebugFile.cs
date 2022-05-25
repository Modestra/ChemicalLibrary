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
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("Файл не удалось создать");
            }
        }
        public void WriteDebugFile(string path, string text)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(text);
        }
    }
}
