using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Demo.Controls;

#region Enums

public enum EnumAction
{
    Wait,
    Start,
    Close
}

public enum EnumType
{
    Success,
    Warning,
    Error,
    Info
}

#endregion

public partial class AlertDemo : Window
{
    private EnumAction _action;
    private DispatcherTimer _timer;
    private double _x, _y;
    private Point Location;

    private static readonly Color DefaultBackgroundColor = Colors.Transparent;

    private static readonly Dictionary<EnumType, Color> AlertTypeColors = new()
    {
        { EnumType.Success, Colors.SeaGreen },
        { EnumType.Error, Colors.DarkRed },
        { EnumType.Info, Colors.RoyalBlue },
        { EnumType.Warning, Colors.DarkOrange }
    };

    public AlertDemo()
    {
        InitializeComponent();
        _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(1) };
        _timer.Tick += Timer_Tick;
    }

    #region Public Methods


    public void ShowAlert(string msg, EnumType type)
    {
        Opacity = 0;
        WindowStartupLocation = WindowStartupLocation.Manual;

        Debug.WriteLine($"AlertDemo count: {Application.Current.Windows.OfType<AlertDemo>().Count()}");

        for (int i = 1; i < 10; i++)
        {
            string fName = $"alert{i}";
            var alertDemo = Application.Current.Windows.OfType<AlertDemo>().FirstOrDefault(w => w.Name == fName) as AlertDemo;

            if (alertDemo == null)
            {
                Name = fName;
                _x = SystemParameters.WorkArea.Width - Width - 5;
                _y = SystemParameters.WorkArea.Height - Height * i - 5 * i;
                Left = _x;
                Top = _y;
                Location = new Point(_x, _y);
                break;
            }
        }

        SetAlertImageAndBackground(type);
        StartTime(msg);

        Show();
    }

    #endregion

    #region Private Methods

    private void Timer_Tick(object sender, EventArgs e)
    {
        switch (_action)
        {
            case EnumAction.Wait:
                SetTimerInterval(5000);
                _action = EnumAction.Close;
                break;
            case EnumAction.Start:
                SetTimerInterval(1);
                Opacity += 0.1;
                if (_x < Location.X)
                {
                    Left--;
                }
                if (Opacity > 1.0)
                {
                    _action = EnumAction.Wait;
                }
                break;
            case EnumAction.Close:
                SetTimerInterval(1);
                Opacity -= 0.1;
                Left -= 3;
                if (Opacity < 0.0)
                {
                    Close();
                }
                break;
        }
    }

    private void SetAlertImageAndBackground(EnumType type)
    {
        var color = GetAlertBackgroundColor(type);
        imageBox.Source = new BitmapImage(new Uri($"pack://application:,,,/Demo.Controls;component/Assets/Icons/{type.ToString().ToLower()}.png", UriKind.RelativeOrAbsolute));
        border.Background = new SolidColorBrush(color);
    }

    private Color GetAlertBackgroundColor(EnumType type)
    {
        tb_Title.Text = type.ToString();
        return AlertTypeColors.ContainsKey(type) ? AlertTypeColors[type] : DefaultBackgroundColor;
    }

    private void StartTime(string msg)
    {
        lblMsg.Text = msg;
        _action = EnumAction.Start;
        SetTimerInterval(1);
        _timer.Start();
    }

    private void SetTimerInterval(int milliseconds) => _timer.Interval = TimeSpan.FromMilliseconds(milliseconds);

    private void HandleCloseButton()
    {
        SetTimerInterval(1);
        _action = EnumAction.Close;
    }


    #endregion

    #region Controls Event Methods

    private void Alert_PreviewMouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        HandleCloseButton();
    }

    #endregion

}
