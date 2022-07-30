namespace Logger;
/// <summary>
/// Интерфейс вывода сообщений
/// </summary>
public interface ILogger
{
    /// <summary>
    /// Метод вывода информационных сообщений
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Info(string message);
    /// <summary>
    /// Метод вывода сообщений предупреждения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Warning(string message);
    /// <summary>
    /// Метод вывода сообщений ошибок
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Error(string message);
    /// <summary>
    /// Метод вывода сообщений выполнения
    /// </summary>
    /// <param name="message">Текст сообщения</param>
    public void Success(string message);
    /// <summary>
    /// Метод вывода пользовательских сообщений
    /// </summary>
    /// <param name="type">Тип пользовательского сообщения</param>
    /// <param name="message">Текст сообщения</param>
    public void Custom(string type, string message);
}
