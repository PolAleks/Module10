using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_2_2
{
    internal class Writer : IWrater
    {
        void IWrater.Write()
        {
            Console.WriteLine("Чего-то пишем на консоль");
        }
    }
    interface IWrater
    {
        void Write();
    }
}
