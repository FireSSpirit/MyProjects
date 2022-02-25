using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingGames
{
    class Program
    {
        // Пример использования интерфейса.

        static void Main(string[] args)
        {

            Publisher ea = new Publisher
            {
                Name = "EA",
                Money = 2000000000,
                CountEmployee = 20000
            };

            Studio dice = new Studio
            {
                Name = "DICE",
                Budget = 100000000,
                AmountEmployees = 500,
                EngineName = "Frostbyte",
                ExpectedTime = "Ждем 3-4 года"
            };

            TeamOfStudio teamofDice_1 = new TeamOfStudio
            {
                AmountEmployees = 200
            };

            AdvertisingDepartment adForGameDice = new AdvertisingDepartment
            {
                Budget = 50000000,
                AmountEmployees = 10
            };

            Console.WriteLine("Общий бюджет {0} до разработки: {1} $, рекламе будущего проекта выделено {2} $, студии выделено {3} $",
   ea.Name, ea.Money, adForGameDice.Budget, dice.Budget);
            Console.WriteLine("Из всех сотрудников {0} {1}, выделено на разработку игры {2} человек, а для рекламы задействовано {3} человек",
   dice.Name, dice.AmountEmployees, teamofDice_1.AmountEmployees, adForGameDice.AmountEmployees);
            Console.WriteLine("");
            //исходные данные

            ea.Expenses(dice.Budget + adForGameDice.Budget);
            // траты компании

            Console.Write(ea.Name + " ");
            ea.Goal();
            Console.WriteLine();
            Console.WriteLine();
            ea.Work(dice);
            dice.Work(teamofDice_1);
            ea.Work(adForGameDice);
            //выполнение работы

            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Итог");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Поздравляем!");
            Console.WriteLine("Игра от {0} с бюджетом {1} $ и разработанная {2} сотрудниками вышла!",
                dice.Name, dice.Budget + adForGameDice.Budget, adForGameDice.AmountEmployees + teamofDice_1.AmountEmployees);
            teamofDice_1.Earn(300000000);
            ea.Earning(teamofDice_1.Earning, teamofDice_1.AmountEmployees);
            Console.WriteLine("Игра принесла: {0} $", teamofDice_1.Earning);
            Console.WriteLine("Текущий бюджет {0} {1} $", ea.Name, ea.Money);

            teamofDice_1.EndOfWorking();
            Console.ReadKey();
            //Пример использования интерфейса, где над игрой могут работать не только студия разработчик, но и косвенно
            //её рекламная компания. А скажем, если взять вместо рекламного отдела другую студию разработчика этого же издателя,
            //было бы уже логичнее использовать абстрактный класс, потому что у них бы было довольно много схожих членов.

        }
    }
}
