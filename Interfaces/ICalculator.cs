namespace Modul10Interfase
{
    interface ICalculator
    {
        /// <summary>
        /// Возвращает сумму двух чисел, приводимых к double.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="FirstTerm"></param>
        /// <param name="SecondTerm"></param>
        /// <returns></returns>
        double Sum<T>(T FirstTerm, T SecondTerm) where T : struct;
    }
}
