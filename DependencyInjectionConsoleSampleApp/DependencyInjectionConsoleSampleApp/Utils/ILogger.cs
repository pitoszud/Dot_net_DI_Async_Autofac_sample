namespace DependencyInjectionConsoleSampleApp.Utils
{
    public interface ILogger
    {
        string currentMessage { get; set; }

        void Log(string message);
    }
}