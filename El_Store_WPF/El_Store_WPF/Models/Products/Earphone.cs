namespace El_Store_WPF.Models
{
    // Класс-наследник Наушники.
    // Свойства наушников: минимальная и максимальная частоты, проводные наушники или нет
    class Earphone : Product
    {
        #region Properties
        public int MinHz { get; set; }
        public int MaxHz { get; set; }
        public bool Wireless { get; set; }
        public string TextWireless
        {
            get { return Wireless ? "Да" : "Нет"; }
        }
        #endregion
        #region Constructor
        public Earphone(int id, string name, decimal price, string manufacturer, int count, int minHz, int maxHz, bool wireless) : base(id, name, price, manufacturer, count)
        {
            MinHz = minHz;
            MaxHz = maxHz;
            Wireless = wireless;
            TypeProduct = Type.Earphone;
        }
        #endregion
    }
}