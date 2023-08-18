using System;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Demo.Controls
{
    public partial class CardButton : UserControl
    {
        public CardButton()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var button = sender as Button;
            var widthAnimation = new DoubleAnimation() { To = 130, Duration = TimeSpan.FromSeconds(0.3) };
            var heightAnimation = new DoubleAnimation() { To = 150, Duration = TimeSpan.FromSeconds(0.3) };

            button.BeginAnimation(WidthProperty, widthAnimation);
            button.BeginAnimation(HeightProperty, heightAnimation);

        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            var button = sender as Button;
            var widthAnimation = new DoubleAnimation() { To = 100, Duration = TimeSpan.FromSeconds(0.3) };
            var heightAnimation = new DoubleAnimation() { To = 120, Duration = TimeSpan.FromSeconds(0.3) };

            button.BeginAnimation(WidthProperty, widthAnimation);
            button.BeginAnimation(HeightProperty, heightAnimation);
        }
    }
}
