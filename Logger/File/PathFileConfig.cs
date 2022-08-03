using System.Text.Json;
using Logger.Console;

namespace Logger.File;
/// <summary>
/// Класс конфигурирования файлов логирования
/// </summary>
public class PathFileConfig
{
    /// <summary>
    /// Свойство хранения пути файла логирования информационных сообщений
    /// </summary>
    public string PathInfo { get; set; }
    /// <summary>
    /// Свойство хранения пути файла логирования сообщений предупреждений
    /// </summary>
    public string PathWarning { get; set; }
    /// <summary>
    /// Свойство хранения пути файла логирования сообщений ошибок
    /// </summary>
    public string PathError { get; set; }
    /// <summary>
    /// Свойство хранения пути файла логирования сообщений успешного выполнения
    /// </summary>
    public string PathSuccess { get; set; }
    /// <summary>
    /// Свойство хранения пути файла логирования пользовательских сообщений
    /// </summary>
    public string PathCustom { get; set; }
    /// <summary>
    /// Статический метод класса PathFileConfig для определения конфигурации методов из файла
    /// </summary>
    /// <param name="path">Путь к файлу конфигурации</param>
    /// <returns>Объект собственного класса с устанвленным набором путей к файлам логирования</returns>
    public static PathFileConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.DeserializeAsync<PathFileConfig>(file).Result;
    }
}
