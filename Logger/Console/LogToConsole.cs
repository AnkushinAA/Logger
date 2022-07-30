namespace Logger.Console;
/// <summary>
/// Класс логирования сообщений в консоль
/// </summary>
public class LogToConsole : ILogger
{
    private readonly ConsoleColorConfig _colors;
    /// <summary>
    /// Конструктор (по умолчанию) класса LogToConsole который создает объект конфигарации
    /// </summary>
    public LogToConsole()
    {
        _colors = ConsoleColorConfig.Init("log_colors.json");
    }
    /// <summary>
    /// Конструктор (с параметрами) класса LogToConsole который создает объект конфигарации, который принимает путь к файлу конфигурации
    /// </summary>
    /// <param name="pathToColorsConfig">Путь к файлу конфигурации</param>
    public LogToConsole(string pathToColorsConfig)
    {
        _colors = ConsoleColorConfig.Init(pathToColorsConfig);
    }
    /// <summary>
    /// Статический метод вывода в консоль сообщений по принятым параметрам
    /// </summary>
    /// <param name="message">Текст сообщений</param>
    /// <param name="color">Цвет текста сообщений</param>
    private static void WriteToConsole(string message, ConsoleColor color)
    {
        System.Console.ForegroundColor = color;
        System.Console.WriteLine($"{DateTime.Now:g} {message}");
        System.Console.ResetColor();
    }
    /// <summary>
    /// Метод вывода в консоль информационных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Info(string message)
    {
        WriteToConsole($"[INFO] {message}", _colors.ColorInfo);
    }
    /// <summary>
    /// Метод вывода в консоль сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Warning(string message)
    {
        WriteToConsole($"[WARNING] {message}", _colors.ColorWarning);
    }
    /// <summary>
    /// Метод вывода в консоль сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Error(string message)
    {
        WriteToConsole($"[ERROR] {message}", _colors.ColorError);
    }
    /// <summary>
    /// Метод вывода в консоль сообщений выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Success(string message)
    {
        WriteToConsole($"[SUCCESS] {message}", _colors.ColorSuccess);
    }
    /// <summary>
    /// Метод вывода в консоль пользовательских сообщений
    /// </summary>
    /// <param name="type">Пользовательский тип сообщения</param>
    /// <param name="message">Текст сообщения</param>
    public void Custom(string type, string message)
    {
        WriteToConsole($"[{type}] {message}", _colors.ColorCustom);
    }
}
