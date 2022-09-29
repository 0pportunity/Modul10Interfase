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
                    Calc.Logger.Event("Калькулятор суммы запущен");

                    Console.WriteLine("Введите первое слагаемое:");
                    var oneNum = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе слагаемое:");
                    var twoNum = Convert.ToDouble(Console.ReadLine());

                    var resultSum = ((ICalculator)Calc).Sum(oneNum, twoNum);
                    Console.WriteLine($"\nРезультат: {resultSum}\n");
                }
                catch (FormatException ex)
                {
                    Calc.Logger.Error($"Введено некорректное значение!\n{ex.Message}");
                }
            }
        }
    }
}

