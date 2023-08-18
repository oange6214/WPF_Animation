using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Demo.Controls
{
    public partial class AnimateRectangle : UserControl
    {
        public AnimateRectangle()
        {
            InitializeComponent();
        }


        public double? To
        {
            get { return (double)GetValue(ToProperty); }
            set { SetValue(ToProperty, value); }
        }

        public static readonly DependencyProperty ToProperty =
            DependencyProperty.Register("To", typeof(double?), typeof(AnimateRectangle), new PropertyMetadata(360.0));

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(AnimateRectangle), new PropertyMetadata(string.Empty));

        public Brush Stroke
        {
            get { return (Brush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }

        public static readonly DependencyProperty StrokeProperty =
            DependencyProperty.Register("Stroke", typeof(Brush), typeof(AnimateRectangle), new PropertyMetadata(Brushes.Gray));



        public Duration Duration
        {
            get { return (Duration)GetValue(DurationProperty); }
            set { SetValue(DurationProperty, value); }
        }

        public static readonly DependencyProperty DurationProperty =
            DependencyProperty.Register("Duration", typeof(Duration), typeof(AnimateRectangle), new PropertyMetadata(default(Duration)));


    }
}
