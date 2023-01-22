namespace DependencyInjection
{
    internal class Program
    {
        static ILogger Logger { get; set; } 
        static void Main(string[] args)
        {
            Logger = new Logger();

            Worker1 worker1 = new Worker1(Logger);

            worker1.WorkerStarted();
        }
    }
    interface ILogger
    {
        void Event(string message);
    }

    public class Logger : ILogger
    {
        public void Event(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IWorker
    {
        void WorkerStarted();
    }
}