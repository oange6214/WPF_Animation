using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Demo.Controls
{
    public partial class Menu01 : UserControl
    {
        private readonly Duration _openCloseDuration = new Duration(TimeSpan.FromSeconds(0.5));

        public Menu01()
        {
            InitializeComponent();
            dropdownContent.Height = 0;
        }

        private void OpenDropdown(object sender, RoutedEventArgs e)
        {
            dropdownInnerContent.Measure(new Size(dropdownContent.MaxHeight, dropdownContent.MaxWidth));
            DoubleAnimation heightAnimation = new DoubleAnimation(dropdownInnerContent.DesiredSize.Height, _openCloseDuration)
            {
                AccelerationRatio = 0.75
            };
            dropdownContent.BeginAnimation(HeightProperty, heightAnimation);
        }

        private void CloseDropdown(object sender, RoutedEventArgs e)
        {
            DoubleAnimation heightAnimation = new DoubleAnimation(0, _openCloseDuration)
            {
                AccelerationRatio = 0.75
            };
            dropdownContent.BeginAnimation(HeightProperty, heightAnimation);
        }
    }
}
