using El_Store_WPF.ViewModels;
using System.Windows;

namespace El_Store_WPF
{
    // Главное окно с данными
    public partial class MainWindow : Window
    {
        private readonly MainViewModel mvm;
        public MainWindow()
        {
            InitializeComponent();
            mvm = new MainViewModel();
            // Связывание данных
            DataContext = mvm;
        }
    }
}
