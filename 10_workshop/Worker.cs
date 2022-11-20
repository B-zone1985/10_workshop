using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _10_workshop
{
    public class Worker : IWorker
    {
        ILogger Logger { get; }
        public Worker(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Logger.Summ("ВВедите число 1: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Logger.Summ("Введите число 2: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                int summ = numberOne + numberTwo;
                Console.WriteLine("Сумма двух чисел равна: \n{0}", summ);
            }
            catch(FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Введено не корректное значение. Введите число!");
            }
        }
    }

}
