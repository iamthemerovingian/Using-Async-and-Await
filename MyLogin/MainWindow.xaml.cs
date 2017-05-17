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

                var loginTask = Task.Run(() =>
                {
                    //throw new UnauthorizedAccessException();

                    Thread.Sleep(2000);
                    return "Login Successful!!";
                });

                var logTask = Task.Delay(2000); //Log the login with the server.

                var purchaseTask = Task.Delay(1000); //Load the customer's files.

                await Task.WhenAll(loginTask, logTask, purchaseTask);

                return loginTask.Result;
            }
            catch (Exception e)
            {
                return "Login Failed!!";
            }
        }
    }
}
