using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Worker1 : IWorker
    {
        ILogger Logger { get; }
        public Worker1(ILogger logger)
        {
            Logger = logger;
        }

        public void WorkerStarted()
        {
            Logger.Event("Я начал работать");
            Thread.Sleep(5000);
            Logger.Event("Я окончил работу");
        }
    }
}
