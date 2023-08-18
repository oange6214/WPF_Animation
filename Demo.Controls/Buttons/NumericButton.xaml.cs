using System;
using System.Windows.Controls;

namespace Demo.Controls
{
    public partial class NumericButton : UserControl
    {
        public NumericButton()
        {
            InitializeComponent();
        }

        private void btn_PlusNum_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);
            if (i < 99)
            {
                btn_Num.Content = i + 1;
            }
        }

        private void btn_MinNum_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            int i = Convert.ToInt32(btn_Num.Content);

            if (i > 0)
            {
                btn_Num.Content = i - 1;
            }
        }
    }
}
