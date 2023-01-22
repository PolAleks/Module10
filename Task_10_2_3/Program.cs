namespace Task_10_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorket)worker).Build();
        }
    }
}