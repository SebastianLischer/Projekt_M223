using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using VotingWPF.Classes;
using VotingWPF.Service;

namespace VotingWPF.Views
{
    public partial class Electon : Window
    {
        private Election election;

        internal Election Election { get => election; set => election = value; }

        public Electon()
        {
            InitializeComponent();
        }

        public void DisplayInfo()
        {
            Elenametxt.Text = election.Name;
            Questiontxt.Text = election.Question;
        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateThisList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataBase db = DataBase.Instance;
            string text = VoteElementInput.Text;
            bool ifNew = db.VoteElementService.ReturnTrueIfElementNew(text);
            if (ifNew != true)
            {
                VoteElement voteElementNew = new VoteElement(text);
                election.AddOption(voteElementNew);
                UpdateThisList();
            }
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
            this.Close();
        }
        private void UpdateThisList()
        {
            List<ElectionOption> elections = election.VoteElements;
            electionList.Items.Clear();
            elections.ForEach(election =>
            {
                electionList.Items.Add(election);
            });
        }
    }
}