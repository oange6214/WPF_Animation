using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Demo.Controls.Windows;


public partial class Skooby : Window
{

    public Skooby()
    {
        InitializeComponent();
    }

    private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        DragMove();
    }

    private void txt_Email_LostFocus(object sender, RoutedEventArgs e)
    {
        bool isEmail = Regex.IsMatch(txt_Email.Text.Trim(), @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase);

        if (isEmail)
        {
            img_EmailCheck.Visibility = Visibility.Visible;
            path_Email.Stroke = Brushes.Green;
            txt_Email.Foreground = Brushes.Green;
        }
        else
        {
            path_Email.Stroke = Brushes.Red;
            txt_Email.Foreground = Brushes.Red;
        }
    }

    private void txt_Password_LostFocus(object sender, RoutedEventArgs e)
    {
        if (txt_Password.Password.Trim() != "admin")
        {
            img_PasswordCancel.Visibility = Visibility.Visible;
            img_PasswordCheck.Visibility = Visibility.Hidden;
            path_Password.Stroke = Brushes.Red;
            txt_Password.Foreground = Brushes.Red;
        }
        else
        {
            img_PasswordCancel.Visibility = Visibility.Hidden;
            img_PasswordCheck.Visibility = Visibility.Visible;
            path_Password.Stroke = Brushes.Green;
            txt_Password.Foreground = Brushes.Green;
        }
    }
}
