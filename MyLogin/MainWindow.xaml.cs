using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MyLogin
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoginButton.IsEnabled = false;
                BusyIndicator.Visibility = Visibility.Visible;

                var result = await LoginAsync();
                LoginButton.Content = result;


                LoginButton.IsEnabled = true;
                BusyIndicator.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                LoginButton.Content = "Internal Error!!!";
            }
        }

        private async Task<string> LoginAsync()
        {
            //throw new UnauthorizedAccessException();

            try
            {
                //throw new UnauthorizedAccessException();

                var result = await Task.Run(() =>
                {
                    //throw new UnauthorizedAccessException();

                    Thread.Sleep(2000);
                    return "Login Successful!!";
                });

                return result;
            }
            catch (Exception e)
            {
                return "Login Failed!!";
            }
        }
    }
}
