using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;
namespace AsyncEx
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch(); // секундомер
            stopWatch.Start(); // запустить секундомер
            Task tomTask = PrintNameAsync("Tom");
            var bobTask = PrintNameAsync("Bob");
            var samTask = PrintNameAsync("Sam");

            await tomTask;
            await bobTask;
            await samTask;
            Console.WriteLine();
            stopWatch.Stop(); // остановить секундомер

            TimeSpan ts = stopWatch.Elapsed; // структура для работы с временем
            Console.WriteLine($"{ts.Seconds:00}:{ts.Milliseconds:00}"); // вывод секунд и милисекунд
            async Task PrintNameAsync(string name)
            {
                await Task.Delay(3000);     // имитация продолжительной работы
                Console.WriteLine(name);
            }
        }
    }
}
