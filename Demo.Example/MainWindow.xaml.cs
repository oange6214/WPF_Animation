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

        private void Success_Click(object sender, RoutedEventArgs e)
        {
            AlertDemo alertDemo = new AlertDemo();
            alertDemo.ShowAlert("Success Message", EnumType.Success);
        }

        private void Error_Click(object sender, RoutedEventArgs e)
        {
            AlertDemo alertDemo = new AlertDemo();
            alertDemo.ShowAlert("Error Message", EnumType.Error);
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            AlertDemo alertDemo = new AlertDemo();
            alertDemo.ShowAlert("Info Message", EnumType.Info);
        }

        private void Warning_Click(object sender, RoutedEventArgs e)
        {
            AlertDemo alertDemo = new AlertDemo();
            alertDemo.ShowAlert("Warning Message", EnumType.Warning);
        }
    }
}
