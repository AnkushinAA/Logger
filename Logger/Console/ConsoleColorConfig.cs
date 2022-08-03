using System.Text.Json;

namespace Logger.Console;
/// <summary>
/// Класс для конфигурирования цвета текста в консоли
/// </summary>
public class ConsoleColorConfig
{
    /// <summary>
    /// Свойство класса ConsoleColor для определения цвета информационного текста в консоли
    /// </summary>
    public ConsoleColor ColorInfo { get; set; }
    /// <summary>
    /// Свойство класса ConsoleColor для определения цвета текста предупреждений в консоли
    /// </summary>
    public ConsoleColor ColorWarning { get; set; }
    /// <summary>
    /// Свойство класса ConsoleColor для определения цвета текста ошибок в консоли
    /// </summary>
    public ConsoleColor ColorError { get; set; }
    /// <summary>
    /// Свойство класса ConsoleColor для определения цвета текста успешного выполнения в консоли
    /// </summary>
    public ConsoleColor ColorSuccess { get; set; }
    /// <summary>
    /// Свойство класса ConsoleColor для определения цвета пользовательского текста в консоли
    /// </summary>
    public ConsoleColor ColorCustom { get; set; }
    /// <summary>
    /// Статический метод для определения конфигурации методов из файла
    /// </summary>
    /// <param name="path">Путь к файлу конфигурации</param>
    /// <returns>Объект собственного класса с необходимыми установками цвета текста</returns>
    public static ConsoleColorConfig Init(string path)
    {
        using var file = new FileStream(path, FileMode.Open, FileAccess.Read);
        return JsonSerializer.DeserializeAsync<ConsoleColorConfig>(file).Result;
    }
}
