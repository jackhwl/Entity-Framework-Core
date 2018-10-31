﻿using System;
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
            catch (Exception )
            {
                LoginButton.Content = "Internal error!";
            }
            //LoginButton.IsEnabled = false;
            //var task = Task.Run(() =>
            //{
            //    Thread.Sleep(2000);
            //    return "Login Successful!";
            //});

            //task.ConfigureAwait(true)
            //    .GetAwaiter()
            //    .OnCompleted(() =>
            //    {
            //        LoginButton.Content = task.Result;
            //        LoginButton.IsEnabled = true;
            //    });
        }

        private async Task<string> LoginAsync()
        {
            // throw new UnauthorizedAccessException();
            try
            {
                var result = await Task.Run(() =>
                {
                    //throw new UnauthorizedAccessException();
                    Thread.Sleep(2000);
                    return "Login Successful!";
                });
                //UI
                await Task.Delay(2000); //Log the login
                //UI
                await Task.Delay(1000); //Fetch purchases
                //UI
                return result;
            }
            catch (Exception)
            {
                return "Login failed!";
            }


        }
    }
}
