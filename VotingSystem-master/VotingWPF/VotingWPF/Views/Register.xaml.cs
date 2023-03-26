using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using VotingWPF.Service;

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy Registert.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new MainWindow();
            this.Close();
            startPanel.Show();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void RegisterButtonVoter_Click(object sender, RoutedEventArgs e)
        {
            DataBase lists = DataBase.Instance;
            int age = 0;
            string message = "ERROR";
            //Verify password
            if(passwordtxt.Text.Length < 8)
            {
                message = "Password must be at least 8 characters long";
                MessageBox.Show(message);
                return;
            }
            else if(!isValidPassword(passwordtxt.Text))
            {
                message = "Password must contain at least one letter and one digit";
                MessageBox.Show(message);
                return;
            }

            //Check if username is epmty
            if (string.IsNullOrEmpty(usernametxt.Text) && string.IsNullOrEmpty(passwordtxt.Text) && string.IsNullOrEmpty(nametxt.Text) && string.IsNullOrEmpty(lastnametxt.Text))
            {
                message = "Username is empty";
                MessageBox.Show(message);
                return;
            }
            //Verify Age
            if (agetxt.Text != "" && Regex.IsMatch(agetxt.Text, "^[1-9][0-9][0-9]?$"))
            {
                Int32.TryParse(agetxt.Text, out age);
            }
            else
            {
                MessageBox.Show(message, "Age is invalid", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //If username unique add it and close regestration window
            if (lists.VoterService.AddVoter(usernametxt.Text, passwordtxt.Text, nametxt.Text, lastnametxt.Text, age, adminpasswordtxt.Text))
            {
                Window startPanel = new MainWindow();
                this.Close();
                startPanel.Show();
            }

        }
        static bool isValidPassword(string password)
        {
            return
               password.Any(c => IsLetter(c)) &&
               password.Any(c => IsDigit(c));
        }
        static bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}