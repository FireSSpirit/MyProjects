using System.Windows;
using System.Diagnostics;
using System.Windows.Navigation;

namespace El_Store_WPF.Views
{
    // Окно с информацией о выбранных наушниках
    public partial class EarphoneWindow : Window
    {
        public EarphoneWindow()
        {
            InitializeComponent();
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
