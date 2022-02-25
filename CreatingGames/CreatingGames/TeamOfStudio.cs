using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGames
{
    class TeamOfStudio : IWorking
    {
        public int Earning { get; set; }
        public int AmountEmployees { get; set; }

        public TeamOfStudio()
        {

        }

        public void Work()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Работа команды разработчиков");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Придумываем ключевую фишку игры");
            Console.WriteLine("Придумываем геймплей");
            Console.WriteLine("Пишем сюжет");
            Console.WriteLine("Потрачен бюджет, выделенный на разработку игры");
            Console.WriteLine("Игра готова к запуску");
            Console.WriteLine("");
            //разработка игры
        }

        public void Earn(int money)
        {
            Earning += money;
        }

        public void EndOfWorking()
        {
            Earning = 0;
            AmountEmployees = 0;
        }
    }
}
