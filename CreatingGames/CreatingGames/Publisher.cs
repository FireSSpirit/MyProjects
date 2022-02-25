using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGames
{
    class Publisher
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public int CountEmployee { get; set; }
        //ресурсы компании 

        public Publisher()
        {
        }

        public void Goal()
        {
            Console.WriteLine("Объясняет задачу студии и рекламному отделу");
        }

        public void Expenses(int money)
        {
            Money -= money;           
        }

        public void Earning(int money, int countEmployee)
        {
            Money += money;
            CountEmployee += countEmployee;
        }

        public void Work(IWorking NewGame)
        {
            NewGame.Work();
            //идет работа
        }
    }
}
