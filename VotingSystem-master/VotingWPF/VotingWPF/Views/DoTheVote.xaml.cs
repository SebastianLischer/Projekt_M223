using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using VotingWPF.Classes;

namespace VotingWPF.Views
{
    public partial class DoTheVote : Window
    {
        private Election election;
        private Voter voter;

        public DoTheVote()
        {
            InitializeComponent();
        }

        internal Election Election { get => election; set => election = value; }
        internal Voter Voter { get => voter; set => voter = value; }
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
        internal void UpdateList()
        {
            Question.Text = election.Question;

            List<ElectionOption> elections = election.VoteElements;
            electionList.Items.Clear();
            elections.ForEach(election =>
            {
                electionList.Items.Add(election);
            });
            // throw new NotImplementedException();
        }
        
        private void Vote_Click(object sender, RoutedEventArgs e)
        {
            if (electionList.Items.Count != 0)
            {
                dynamic VoteElement = electionList.SelectedItem as dynamic;

                election.Voting(Voter, VoteElement.VoteElementText);
            }

            ElectionsPanel panel = (ElectionsPanel)this.Owner;
            panel.UpdateList();
            this.Close();
        }

        private void ElectionList_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateList();
        }
    }
}