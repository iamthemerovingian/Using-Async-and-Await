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
            var result = LoginAsync().Result;
        }

        private async Task<string> LoginAsync()
        {
            //throw new UnauthorizedAccessException();

            try
            {
                //throw new UnauthorizedAccessException();

                var loginTask = Task.Run(async () =>
                {
                    //throw new UnauthorizedAccessException();

                    await Task.Delay(2000);

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
