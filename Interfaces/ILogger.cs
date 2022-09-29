namespace Modul10Interfase
{
    interface ILogger
    {
        /// <summary>
        /// Вывод сообщения о событии
        /// </summary>
        /// <param name="message"></param>
        void Event(string message);

        /// <summary>
        /// Вывод сообщения об ошибке
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);
    }
}
