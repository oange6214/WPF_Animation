using System.Windows;

namespace Demo.Controls.Windows
{
    public partial class RippleApp : Window
    {
        public RippleApp()
        {
            InitializeComponent();
        }

        private void Close_App_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
