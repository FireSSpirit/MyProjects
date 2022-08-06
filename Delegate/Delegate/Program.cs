using System;

namespace Delegate
{
    class Program
    {
        delegate void Message();
        static void Main(string[] args)
        {
            Message mes;            // 2. Создаем переменную делегата
            mes = Hello;            // 3. Присваиваем этой переменной адрес метода
            mes += Bye;
            mes += Hello;
            mes();                  // 4. Вызываем метод
            Console.WriteLine();
            mes -= Hello;
            mes();
            void Hello() => Console.WriteLine("Hello");
            void Bye() => Console.WriteLine("Bye");
        }
    }
}
