using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10_2_4
{
    interface IWorker
    {
        public void Build();
    }
    internal class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Строим Workera");
        }
    }
}
