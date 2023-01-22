namespace Task_10_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker) worker).Build();
        }
    }
}