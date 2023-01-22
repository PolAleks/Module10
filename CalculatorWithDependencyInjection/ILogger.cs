﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithDependencyInjection
{
    internal interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }
}
