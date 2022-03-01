using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 30000)
            {
                return Price;
            }

            if (user.Spent < 100000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
            // виртуальный метод скидки, который может быть переопределен потомком
        }
    }
}
