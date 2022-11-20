using System;

namespace _10_workshop
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var worker = new Worker(Logger);
            worker.Work();

            Console.ReadKey();
        }
    }

    public interface ILogger /// определяем наш интерфейс
    {
        void Summ(string message); /// добавляем метод
    }

    public class Logger : ILogger /// создаем класс, который будет реализовывать не явно ILogger
    {

        public void Summ(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IWorker /// определяем интерфейс . что будет делать наш класс Summ
    {
        void Work(); /// исполнение метода
    }
}
