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
                await LoginAsync();
            }
            catch (Exception ex)
            {
                LoginButton.Content = "Login Failed";
            }
        }

        private async Task LoginAsync()
        {
            throw new UnauthorizedAccessException();

            try
            {
                //throw new UnauthorizedAccessException();

                var result = await Task.Run(() =>
                {
                    //throw new UnauthorizedAccessException();

                    Thread.Sleep(2000);
                    return "Login Successful!!";
                });

                LoginButton.Content = result;
            }
            catch (Exception e)
            {
            }
        }
    }
}
