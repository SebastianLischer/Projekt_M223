using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using VotingWPF.Classes;
using VotingWPF.Repositoriy;
using VotingWPF.Service;
using VotingWPF.Views;

namespace VotingWPF
{
    public partial class Login : Window
    {
        public Login()
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

        private void LoginButton_Click_1(object sender, RoutedEventArgs e)
        {
            DataBase lists = DataBase.Instance;
            Button roleCheck = sender as Button;
            if (roleCheck.Name == "LoginButton")
            {
                Voter voter = lists.VoterService.Login(logintxt.Text, passwordtxt.Text);

                if (voter != null)
                {
                    ElectionsPanel electionsPanel = new ElectionsPanel();
                    electionsPanel.Voter = voter;
                    electionsPanel.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login or password");
                    return;
                }
            }
        }
    }
}