using Demo.Controls;
using System.Windows;

namespace Demo.Example
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuButton menuButton = new MenuButton();
            menuButton.Show();
        }
    }
}
