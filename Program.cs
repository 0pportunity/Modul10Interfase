using System;

namespace Modul10Interfase
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator(new Logger());
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите первое слагаемое:");
                    var oneNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе слагаемое:");
                    var twoNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(((ICalculator)Calc).Sum(oneNum, twoNum));
                }

                catch (FormatException ex)
                {
                    Calc.Logger.Error($"Введено некорректное значение!\n{ex.Message}");
                }
            }
        }
    }
}

