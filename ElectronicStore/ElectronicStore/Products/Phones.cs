using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Products
{
    class Phones: Product
    {
        public double Diagonal { get; private set; }
        public string Color { get; private set; }
        // Свойства телефона: диагональ и цвет
        public Phones(string name, int price, string manufacturer, double diagonal, string color)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Diagonal = diagonal;
            Color = color;
        }

        public override double GetDiscountPrice(User user)
        {
            return Price * 0.5;
            // переопределенный метод, который предоставляет скидку в 50% всем пользователям
        }
    }
}
