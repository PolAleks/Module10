namespace CalculatorWithDependencyInjection
{
    internal class Program
    {
        static ILogger logger = new Logger();
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(logger);
            calc.Work();
        }
    }
}