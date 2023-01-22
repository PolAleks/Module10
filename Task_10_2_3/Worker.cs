using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_2_3
{
    interface IWorket
    {
        public void Build();
    }
    internal class Worker : IWorket
    {
        public void Build()
        {
            Console.WriteLine("Идет процесс создания Workera");
        }
    }
}
