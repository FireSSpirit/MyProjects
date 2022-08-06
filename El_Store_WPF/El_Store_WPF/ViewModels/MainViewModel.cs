using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using El_Store_WPF.Models;
using El_Store_WPF.Views;

namespace El_Store_WPF.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public static ObservableCollection<Product> products;
        public BaseVM baseVM;
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged("Products");
            }
        }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddWindow addWindow = new AddWindow(new Product());
                        if (addWindow.ShowDialog() == true)
                        {
                            Product product = addWindow.Product;
                            product.Id = Products.Count + 1;
                            Products.Add(product);
                            baseVM.AddDB(product);
                        }
                    }));                
            }
        }
        private RelayCommand editCommand;

        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      Product product = selectedItem as Product;
                      if (product == null) return;

                      Product vm = new Product
                      {
                          Id = product.Id,
                          Name = product.Name,
                          Price = product.Price,
                          Manufacturer = product.Manufacturer,
                          Count = product.Count
                      };
                      AddWindow addWindow = new AddWindow(vm);

                      if (addWindow.ShowDialog() == true)
                      {
                          product.Name = addWindow.Product.Name;
                          product.Price = addWindow.Product.Price;                         
                          product.Manufacturer = addWindow.Product.Manufacturer;
                          product.Count = addWindow.Product.Count;
                          baseVM.UpdateDB(product);
                      }
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                    (removeCommand = new RelayCommand(obj =>
                    {
                        Product product = obj as Product;
                        if (product != null)
                        {
                            Products.Remove(product);
                            baseVM.DeleteDB(product.Id);
                        }
                    }, (obj) => Products.Count > 0));
            }
        }

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

        public MainViewModel()
        {
            baseVM = new BaseVM();
            baseVM.StartDB();
        }
    }
}
