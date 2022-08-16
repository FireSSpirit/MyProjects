namespace El_Store_WPF.Models
{
    // Родительский класс, представляющий из себя Товар со свойствами,
    // которые есть у каждого созданного продукта
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Count { get; set; }
        public Type TypeProduct { get; set; }
        public string TextType
        {
            get { return TypeProduct == Type.Phone ? "Смартфон" : "Наушники"; }
        }
        public string HyperLink
        {
            get { return "https://yandex.ru/search/?text=" + Manufacturer + "+" + Name; }
        }
        #endregion
        #region Constructor
        public Product(int id, string name, decimal price, string manufacturer, int count)
        {
            Id = id;
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Count = count;
        }
        #endregion
    }
}
