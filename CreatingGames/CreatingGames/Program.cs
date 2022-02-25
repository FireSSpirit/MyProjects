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

            EA ea = new EA
            {
                Money = 2000000000,
                CountEmployee = 20000
            };

            Dice dice = new Dice
            {
                Budget = 100000000,
                AmountEmployees = 500
            };

            AddDiceGame addDiceGame = new AddDiceGame
            {
                Budget = 5000000,
                AmountEmployees = 40
            };

            Console.WriteLine("Из общего бюджета ЕА {0}, выделено на разработку игры {1} $ и на ее продвижение {2} $",
    ea.Money, dice.Budget, addDiceGame.Budget);
            Console.WriteLine("Из всех сотрудников ЕА {0}, выделено на разработку игры {1} человек и на ее продвижение {2} человек",
    ea.CountEmployee, dice.AmountEmployees, addDiceGame.AmountEmployees);
            Console.WriteLine("");
            //исходные данные

            ea.Expenses(dice.Budget, dice.AmountEmployees);
            ea.Expenses(addDiceGame.Budget, addDiceGame.AmountEmployees);
            // траты компании

            ea.Work(dice);
            ea.Work(addDiceGame);
            //выполнение работы

            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Итог");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Поздравляем!");
            Console.WriteLine("Игра от Dice с бюджетом {0} $ и разработанная {1} сотрудниками вышла!",
                dice.Budget + addDiceGame.Budget, dice.AmountEmployees + addDiceGame.AmountEmployees);

            Console.WriteLine("Текущий бюджет ЕА {0} $", ea.Money);

            Console.ReadKey();
            // Пример использования интерфейса, где над игрой могут работать не только студия разработчик, но и косвенно
            // её рекламная компания. А скажем, если взять вместо рекламного отдела другую студию разработчика этого же издателя,
            // было бы уже логичнее использовать абстрактный класс, потому что у них бы было довольно много схожих членов.
        }
    }

    public interface IWorking
    {
        void Work();
    }

    public class Dice : IWorking
    {
        public int Budget { get; set; }
        public int AmountEmployees { get; set; }

        public Dice()
        {

        }
       
        public void Work()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Работа студии разработки");
            Console.WriteLine(new String('-', 25));
            Console.WriteLine("Создаем игру на движке FrostBite");
            Console.WriteLine("Проходит 3-4 года");            
            Console.WriteLine("Потрачен бюджет и игра создана");
            Console.WriteLine("");
            // работа студии
        }
    }

    public class AddDiceGame : IWorking
    {
        public int Budget { get; set; }
        public int AmountEmployees { get; set; }

        public AddDiceGame()
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

    public class EA
    {
        public int Money { get; set; }
        public int CountEmployee { get; set; }
        //ресурсы компании 

        public EA()
        {

        }
                   
        public void Expenses(int money, int countEmployee)
        {
            Money -= money;
            CountEmployee -= countEmployee;    
        }

        public void Work(IWorking NewGame)
        {
            NewGame.Work();           
            //идет работа
        }
    }
}
