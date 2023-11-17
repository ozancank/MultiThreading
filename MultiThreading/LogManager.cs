namespace MultiThreading;

internal class LogManager
{
    private static LogManager? _logManager;

    public static LogManager Default => _logManager ??= new LogManager();

    public event EventHandler<string>? OnLogAdded;

    public void Log(string logMessage)
    {
        OnLogAdded?.Invoke(this, logMessage);
    }
}