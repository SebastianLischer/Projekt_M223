using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VotingWPF.Classes;
using VotingWPF.Service;
namespace VotingWPF.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddElection.xaml
    /// </summary>
    public partial class AddElection : Window
    {
        public AddElection()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataBase db = DataBase.Instance;
            db.ElectionService.AddElection(Elenametxt.Text, Questiontxt.Text);
            AdminElections listView = (AdminElections)this.Owner;
            listView.UpdateList();
            this.Close();

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
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Window startPanel = new AdminElections();
            this.Close();
            startPanel.Show();
        }
    }
}
