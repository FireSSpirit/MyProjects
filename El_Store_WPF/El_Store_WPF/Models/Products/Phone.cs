using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_Store_WPF.Models
{
    class Phone : Product
    {
        private double diagonal;
        private string color;
        public double Diagonal {
            get { return diagonal; }
            set
            {
                diagonal = value;
                OnPropertyChanged("Diagonal");
            }
        }
        public string Color {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged("Color");
            }
        }
        // Свойства телефона: диагональ и цвет
        public Phone(string name, int price, string manufacturer, double diagonal, string color)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Diagonal = diagonal;
            Color = color;
        }
    }
}

//Console.WriteLine("Смартфон:");
//Console.WriteLine("Название: " + samsungGalaxyS21Gray.Name);
//Console.WriteLine("Цена: " + samsungGalaxyS21Gray.Price);
//Console.WriteLine("Производитель: " + samsungGalaxyS21Gray.Manufacturer);
//Console.WriteLine("Диагональ: " + samsungGalaxyS21Gray.Diagonal + "'");
//Console.WriteLine("Цвет: " + samsungGalaxyS21Gray.Color);