using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGames
{
    class Studio : IWorking
    {
        public string Name { get; set; }
        public int Budget { get; set; }
        public int AmountEmployees { get; set; }
        public string EngineName { get; set; }
        public string ExpectedTime { get; set; }
        public Studio()
        {

        }

        public void Work()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Работа студии разработки");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Выделяем команду для разработки");
            Console.WriteLine("Предоставляем команде движок {0}", EngineName);
            Console.WriteLine(ExpectedTime);
            Console.WriteLine("");
            // работа студии
        }
        public void Work(TeamOfStudio teamOfDice)
        {
            Console.WriteLine("Объяснеем команде суть задачи");
            Console.WriteLine();
            teamOfDice.Work();
            //идет работа
        }
    }
}
