using System.Windows;

namespace El_Store_WPF.Views
{
    // Окно для добавления нового продукта
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    }
}
