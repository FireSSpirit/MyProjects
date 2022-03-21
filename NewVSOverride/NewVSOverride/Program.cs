using System;

namespace NewVSOverride
{
    //Если вы работаете с экземпляром класса-наследника через его родительский класс,
    //то в случае, если вы будете вызывать переопределенный виртуальный метод(override),
    //то будет вызвана его реализация из наследника, а если перекрытый(new), то будет вызван метод базового класса.
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Child("Вася");
            Man man2 = new Man("Василий");
            Child child = (Child)man;

            //child = (Child)man2;
            // сверху down-cast преобразование невозможно
            child.First(); // выведет метод First у Child
            child.Second(); // выведет метод Second у Child

            int i = 0;
            Console.WriteLine(i++);
            Console.Write(i++ + Calculate(i));
            Console.WriteLine(i);

            Console.ReadKey();
        }

        public static int Calculate(int i)
        {
            Console.Write(i++);
            return i;
        }
    }


    class Man
    {
        public string Name { get; set; }
        public Man (string name)
            {
            Name = name;
            }
        public virtual void First()
        {
            Console.WriteLine($"First from Man {Name}");
        }

        public void Second()
        {
            Console.WriteLine($"Second from Man {Name}");
        }
    }

    class Child : Man
    {
        public Child(string name): base(name)
        {
        }
        public override void First()
        {
            Console.WriteLine($"First from Child {Name}");
        }

        public new void Second()
        {
            Console.WriteLine($"Second from Child {Name}");
        }
    }
}
