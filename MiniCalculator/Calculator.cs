using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MiniCalculator
{
    internal class Calculator : ISum
    {
        private int argumentOne;
        private int argumentTwo;

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void Work()
        {
            argumentOne = ReadArgument("Введите значение первого аргумента: ");
            argumentTwo = ReadArgument("Введите значение второго аргумента: ");
            Console.WriteLine($"{argumentOne} + {argumentTwo} = {Sum(argumentOne, argumentTwo)}");
        }
        private int ReadArgument(string message) 
        {
            int result = 0;
            do
            {
                try
                {
                    Console.WriteLine(message);
                    result = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы использовали некорректный формат данных!\n" +
                                      "Попробуйте еще раз: ");
                }
            } while (result == 0);
            return result;
        }

    }
}
