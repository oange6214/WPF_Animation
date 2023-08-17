using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace AnimationDemo
{
    public partial class MainWindow : Window
    {
        private readonly Duration _openCloseDuration = new Duration(TimeSpan.FromSeconds(0.5));

        public MainWindow()
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
