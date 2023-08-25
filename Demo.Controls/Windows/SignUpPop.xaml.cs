using System.Text.RegularExpressions;
using System.Windows;

namespace Demo.Controls.Windows
{
    public partial class SignUpPop : Window
    {
        public SignUpPop()
        {
            InitializeComponent();
        }

        #region Email

        private void txt_Email_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_Email.Visibility = Visibility.Hidden;
        }

        private void txt_Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt_Email.Text.Length == 0)
            {
                lbl_Email.Visibility = Visibility.Visible;
            }
        }

        private void txt_Email_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            bool isEmail = Regex.IsMatch(txt_Email.Text.Trim(), @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", RegexOptions.IgnoreCase);

            if (isEmail)
            {
                img_yesEmail.Visibility = Visibility.Visible;
                img_noEmail.Visibility = Visibility.Hidden;

            }
            else
            {
                img_noEmail.Visibility = Visibility.Visible;
                img_yesEmail.Visibility = Visibility.Hidden;
            }
        }

        #endregion

        #region Password

        private void txt_Password_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_Password.Visibility = Visibility.Hidden;
        }

        private void txt_Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt_Password.Password.Length == 0)
            {
                lbl_Password.Visibility = Visibility.Visible;
            }
        }

        private void txt_Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txt_Password.Password.Length <= 6)
            {
                tb_nofity.Visibility = Visibility.Visible;
                grid_Unreliable.Visibility = Visibility.Visible;
                grid_Average.Visibility = Visibility.Hidden;
                grid_Complicated.Visibility = Visibility.Hidden;
            }
            else if (txt_Password.Password.Length > 6 && txt_Password.Password.Length <= 10)
            {
                tb_nofity.Visibility = Visibility.Hidden;
                grid_Unreliable.Visibility = Visibility.Hidden;
                grid_Average.Visibility = Visibility.Visible;
                grid_Complicated.Visibility = Visibility.Hidden;
            }
            else if (txt_Password.Password.Length > 10)
            {
                tb_nofity.Visibility = Visibility.Hidden;
                grid_Unreliable.Visibility = Visibility.Hidden;
                grid_Average.Visibility = Visibility.Hidden;
                grid_Complicated.Visibility = Visibility.Visible;
            }
        }

        #endregion

        #region Confirm Password

        private void txt_ConfirmPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            lbl_CPassword.Visibility = Visibility.Hidden;
        }

        private void txt_ConfirmPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txt_ConfirmPassword.Password.Length == 0)
            {
                lbl_CPassword.Visibility = Visibility.Visible;
            }
        }

        private void txt_ConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (txt_Password.Password.Trim() == txt_ConfirmPassword.Password.Trim())
            {
                img_yesPass.Visibility = Visibility.Visible;
                img_noPass.Visibility = Visibility.Hidden;
            }
            else
            {
                img_yesPass.Visibility = Visibility.Hidden;
                img_noPass.Visibility = Visibility.Visible;
            }
        }

        #endregion

    }
}
