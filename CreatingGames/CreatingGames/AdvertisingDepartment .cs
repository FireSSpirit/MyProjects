using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGames
{
    class AdvertisingDepartment : IWorking
    {
        public int Budget { get; set; }
        public int AmountEmployees { get; set; }

        public AdvertisingDepartment()
        {

        }
        public void Work()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Работа рекламного отдела");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Придумываем рекламу игре");
            Console.WriteLine("Рекламируем");
            Console.WriteLine("Потрачен бюджет, выделенный на рекламу и игра разрекламирована");
            Console.WriteLine("");
            //работа отдела по рекламе
        }
    }
}
