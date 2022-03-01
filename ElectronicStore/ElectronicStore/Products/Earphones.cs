using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicStore.Products
{
    class Earphones : Product
    {
        public int MinHz { get; private set; }
        public int MaxHz { get; private set; }
        public bool Wire{ get; private set; }
        // Свойства наушников: минимальная и максимальная частоты, проводные наушники или нет
        public Earphones(string name, int price, string manufacturer, int minHz, int maxHz, bool wire)
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
