using System.Windows;
using System.Windows.Input;

namespace VotingWPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoVoteButton_Click(object sender, RoutedEventArgs e)
        {
            Window votePanel = new VoterPanel();
            this.Close();
            votePanel.Show();
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
        private void GoAdminButton_Click(object sender, RoutedEventArgs e)
        {
            Window adminEnter = new AdminEnter();
            this.Close();
            adminEnter.Show();
        }
    }
}