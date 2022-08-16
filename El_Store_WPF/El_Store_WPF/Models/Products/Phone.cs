namespace El_Store_WPF.Models
{
    // Класс-наследник Смартфон.
    // Свойства телефона: диагональ и цвет
    class Phone : Product
    {
        #region Properties
        public double Diagonal { get; set; }
        public string Color { get; set; }
        #endregion
        #region Constructor
        public Phone(int id, string name, decimal price, string manufacturer, int count, double diagonal, string color) : base(id, name, price, manufacturer, count)
        {
            Diagonal = diagonal;
            Color = color;
            TypeProduct = Type.Phone;
        }
        #endregion
    }
}