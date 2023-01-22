using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithDependencyInjection
{
    internal class Calculator : ISum
    {
               
        private int argumentOne;
        private int argumentTwo;

        private delegate void EventLoggerHandler(string message);
        private event EventLoggerHandler ItsCorrectDataEvent; 
        private ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
            ItsCorrectDataEvent += Logger.Event;
        }
        /// <summary>
        /// Обработчик события на корректный ввод данных
        /// </summary>
        /// <param name="message">Сообщение о корректном вводе данных</param>
        private void ArgumetCorrect(string message)
        {
            ItsCorrectDataEvent?.Invoke(message);
        }
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
        /// <summary>
        /// Ввод данных типа int с клавиатуры.
        /// </summary>
        /// <param name="message">Сообщение пользователю с просьбой ввести данные</param>
        /// <returns></returns>
        private int ReadArgument(string message)
        {
            int result = 0;
            do
            {
                try
                {
                    Console.Write(message);
                    result = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Logger.Error("Вы использовали некорректный формат данных!\n" +
                                 "Попробуйте еще раз. ");
                }
            } while (result == 0);

            ArgumetCorrect($"Вы ввели {result}");

            return result;
        }
    }
}
