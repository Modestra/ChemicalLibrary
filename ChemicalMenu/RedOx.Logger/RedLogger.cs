using System.Net;

namespace RedOx.Logger;

public class RedLogger
{
    private string Path { get; set; }

    /// <summary>
    /// Логгер, предназначенный для вывода сообщений в отдельную директорию результата
    /// </summary>
    /// <param name="path">Путь до лог-файла</param>
    public RedLogger(string path)
    {
        Path = path;
    }

    public void CreateFile()
    {
        File.Create(Path);
        File.WriteAllTextAsync(Path, $"{DateTime.Now} - Файл был успешно создан");
    }
    
    /// <summary>
    /// Запись в файл полученные результаты
    /// </summary>
    /// <param name="line">Полученные данные</param>
    public void WriteText(string line)
    {
        File.WriteAllTextAsync(Path, $"{DateTime.Now} - {line}");
    }
    
    /// <summary>
    /// Запись в файл полученные результаты
    /// </summary>
    /// <param name="lines">Список полученных данных</param>
    public void WriteText(string[] lines)
    {
        foreach (string line in lines)
        {
            File.WriteAllTextAsync(Path, $"{DateTime.Now} - {line}");
        }
    }
}