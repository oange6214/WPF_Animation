using System.Windows;

namespace Demo.Controls
{
    public partial class ControlCentre : Window
    {
        public ControlCentre()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
