using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Store_WPF.Models
{
    class Earphone : Product
    {
        private int minHz;
        private int maxHz;
        private bool wire;
        public int MinHz {
            get { return minHz; }
            set
            {
                minHz = value;
                OnPropertyChanged("MinHz");
            }
        }
        public int MaxHz {
            get { return maxHz; }
            set
            {
                maxHz = value;
                OnPropertyChanged("MaxHz");
            }
        }
        public bool Wire {
            get { return wire; }
            set
            {
                wire = value;
                OnPropertyChanged("Wire");
            }
        }
        // Свойства наушников: минимальная и максимальная частоты, проводные наушники или нет
        public Earphone(string name, decimal price, string manufacturer, int minHz, int maxHz, bool wire)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            MinHz = minHz;
            MaxHz = maxHz;
            Wire = wire;
        }
    }
}
//Console.WriteLine("Наушники:");
//Console.WriteLine("Название: " + airpods_2019.Name);
//Console.WriteLine("Цена: " + airpods_2019.Price);
//Console.WriteLine("Производитель: " + airpods_2019.Manufacturer);
//Console.WriteLine("Минимальная частота: " + airpods_2019.MinHz);
//Console.WriteLine("Максимальная частота: " + airpods_2019.MaxHz);
//if (airpods_2019.Wire)
//{
//    Console.WriteLine("Проводные наушники");
//}
//else
//{
//    Console.WriteLine("Беспроводные Bluetooth наушники");
//}