using System;

namespace Modul10Interfase
{
    class Calculator : ICalculator
    {
        public ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        double ICalculator.Sum<T>(T FirstTerm, T SecondTerm)
        {
            Logger.Event("Начало вычислений...");
            double ft = Convert.ToDouble(FirstTerm);
            double st = Convert.ToDouble(SecondTerm);
            Logger.Event("Конец вычислений.");
            return ft + st;
        }
    }
}
