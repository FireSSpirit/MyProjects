using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Products
{
    class TV: Product
    {
        public double Diagonal { get; private set; }
        // Свойства телевизора: диагональ
        public TV(string name, int price, string manufacturer, double diagonal)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Diagonal = diagonal;
        }
        public override double GetDiscountPrice(User user)
        {
            if (user.Name[0] == 'A')
                return Price * 0.28;
            else
                return Price;
            // переопределенный метод, который предоставляет скидку в 28% всем пользователям, у которых имя
            // начинается на А
        }
    }
}
