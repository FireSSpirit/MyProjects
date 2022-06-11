using System;
using ElectronicStore.Products;
namespace ElectronicStore
{
    // Пример применения полиморфизма, без которого в данном случае не обойтись
    // Программа представляет из себя магазин электроники
    // Также сделаны скидки, для них как раз применяется тот самый полиморфизм
        class Program
        {
            static void Main(string[] args)
            {
                User user = new User(
                    "Anatoly",
                    "Улица Пушкина, дом Колотушкина",
                    200000,
                    550
                    );

            // Создание нового пользователя
                Console.WriteLine("Список товаров:");

                TV samsungTV_UE50AU7100U = new TV(
                    "Телевизор Samsung UE50AU7100U LED",
                    50000,
                    "Samsung",
                    50
                    );
            // Создание нового товара
                Console.WriteLine("Телевизор:");
                Console.WriteLine("Название: " + samsungTV_UE50AU7100U.Name);
                Console.WriteLine("Цена: " + samsungTV_UE50AU7100U.Price);
                Console.WriteLine("Производитель: " + samsungTV_UE50AU7100U.Manufacturer);
                Console.WriteLine("Диагональ: " + samsungTV_UE50AU7100U.Diagonal + "'");
                Console.WriteLine(new String('-', 25));

                Earphones airpods_2019 = new Earphones(
                    "Наушники Apple AirPods (2019)",
                    15000,
                    "Apple",
                    20,
                    20000,
                    false
                    );
            // Создание нового товара
                Console.WriteLine("Наушники:");
                Console.WriteLine("Название: " + airpods_2019.Name);
                Console.WriteLine("Цена: " + airpods_2019.Price);
                Console.WriteLine("Производитель: " + airpods_2019.Manufacturer);
                Console.WriteLine("Минимальная частота: " + airpods_2019.MinHz);
                Console.WriteLine("Максимальная частота: " + airpods_2019.MaxHz);
            if (airpods_2019.Wire)
            { 
                Console.WriteLine("Проводные наушники");
            }
            else
            {
                Console.WriteLine("Беспроводные Bluetooth наушники");
            }
                Console.WriteLine(new String('-', 25));

                Earphones xiomiRedmiBuds3Lite = new Earphones(
                    "Беспроводные наушники Xiaomi Redmi Buds 3 Lite",
                    1500,
                    "Apple",
                    20,
                    20000,
                    false
                    );
            // Создание нового товара
                Console.WriteLine("Наушники:");
                Console.WriteLine("Название: " + xiomiRedmiBuds3Lite.Name);
                Console.WriteLine("Цена: " + xiomiRedmiBuds3Lite.Price);
                Console.WriteLine("Производитель: " + xiomiRedmiBuds3Lite.Manufacturer);
                Console.WriteLine("Минимальная частота: " + xiomiRedmiBuds3Lite.MinHz);
                Console.WriteLine("Максимальная частота: " + xiomiRedmiBuds3Lite.MaxHz);
            if (xiomiRedmiBuds3Lite.Wire)
            {
                Console.WriteLine("Проводные наушники");
            }
            else
            {
                Console.WriteLine("Беспроводные Bluetooth наушники");
            }
            Console.WriteLine(new String('-', 25));

            Phones samsungGalaxyS21Gray = new Phones(
                    "Смартфон Samsung Galaxy S21 5G (SM-G991B)",
                    57000,
                    "Samsung",
                    6.2,
                    "Серый"
                    );
            // Создание нового товара
                Console.WriteLine("Смартфон:");
                Console.WriteLine("Название: " + samsungGalaxyS21Gray.Name);
                Console.WriteLine("Цена: " + samsungGalaxyS21Gray.Price);
                Console.WriteLine("Производитель: " + samsungGalaxyS21Gray.Manufacturer);
                Console.WriteLine("Диагональ: " + samsungGalaxyS21Gray.Diagonal + "'");
                Console.WriteLine("Цвет: " + samsungGalaxyS21Gray.Color);
                Console.WriteLine(new String('-', 25));

            Phones iphone13_Blue_128Gb = new Phones(
                    "Смартфон Apple iPhone 13 128 ГБ",
                    82000,
                    "Apple",
                    6.1,
                    "Синий"
                    );
            // Создание нового товара
            Console.WriteLine("Смартфон:");
            Console.WriteLine("Название: " + iphone13_Blue_128Gb.Name);
            Console.WriteLine("Цена: " + iphone13_Blue_128Gb.Price);
            Console.WriteLine("Производитель: " + iphone13_Blue_128Gb.Manufacturer);
            Console.WriteLine("Диагональ: " + iphone13_Blue_128Gb.Diagonal + "'");
            Console.WriteLine("Цвет: " + iphone13_Blue_128Gb.Color);
            Console.WriteLine(new String('-', 25));


            Product[] products = new Product[] {
                samsungTV_UE50AU7100U,
                airpods_2019,
                xiomiRedmiBuds3Lite,
                samsungGalaxyS21Gray,
                iphone13_Blue_128Gb
            };
            // Создание массива типа Product (Проявление апкаста)
                Informer informer = new Informer();
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Здравствуйте {user.Name} ваш баланс {user.Balance}");

                    for (int i = 0; i < products.Length; i++)
                    {
                        Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                    }
                    Console.WriteLine("Выберете номер товара и нажмите Enter:");

                    string str = Console.ReadLine();
                    int productNumber = Convert.ToInt32(str);

                    if (productNumber >= 0 && productNumber < products.Length)
                    {

                        if (products[productNumber].Price < user.Balance)
                        {
                            informer.Buy(user, products[productNumber]);
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Таких товаров нет");
                    }
                }
                // Реализация консольного пользовательского интерфейса
        }
    }
}
