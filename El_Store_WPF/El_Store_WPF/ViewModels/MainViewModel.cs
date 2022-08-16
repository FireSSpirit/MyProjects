using El_Store_WPF.Models;
using El_Store_WPF.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Type = El_Store_WPF.Models.Type;

namespace El_Store_WPF.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        // Реализация интерфейса INotifyPropertyChanged, для работы с командами
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #region Properties
        private Product selectedProduct;
        public Product SelectedProduct
        {
            get { return selectedProduct; }
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        // объявление базы данных
        public BaseVM MyBaseVM { get; set; }
        // создание коллекций
        public static ObservableCollection<Product> Products { get; set; }
        public static ObservableCollection<Phone> Phones { get; set; }
        public static ObservableCollection<Earphone> Earphones { get; set; }       
        
        // создание комманд
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        MyBaseVM.AddDB();
                    }));                
            }
        }

        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand(selectedItem =>
                  {
                      Product product = selectedItem as Product;
                      if (product == null) return;
                      MyBaseVM.UpdateDB(product);                      
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(selectedItem =>
                    {
                        Product product = selectedItem as Product;
                        if (product == null) return;
                        MyBaseVM.DeleteDB(product);
                        Products.Remove(product);
                    }, (obj) => Products.Count > 0));
            }
        }

        private RelayCommand infoCommand;
        public RelayCommand InfoCommand
        {
            get
            {
                return infoCommand ??
                    (infoCommand = new RelayCommand((selectedItem) =>
                    {
                        Product product = selectedItem as Product;
                        if (product == null) return;
                        if (product.TypeProduct == Type.Phone)
                        {
                            Phone phone = Phones.Where(x => x.Id == product.Id).FirstOrDefault();
                            PhoneWindow phoneWindow = new PhoneWindow();
                            phoneWindow.DataContext = phone;
                            if (phoneWindow.ShowDialog() == true) {}
                        }
                        else if (product.TypeProduct == Type.Earphone)
                        {
                            Earphone earphone = Earphones.Where(x => x.Id == product.Id).FirstOrDefault();
                            EarphoneWindow earphoneWindow = new EarphoneWindow();
                            earphoneWindow.DataContext = earphone;
                            if (earphoneWindow.ShowDialog() == true) { }
                        }
                    }));
            }
        }
        #endregion
        #region Constructor
        public MainViewModel()
        {           
            MyBaseVM = new BaseVM();
            MyBaseVM.StartDB();
        }
        #endregion
    }
}
