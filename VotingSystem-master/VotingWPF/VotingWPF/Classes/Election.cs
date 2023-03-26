using System.Collections.Generic;

namespace VotingWPF.Classes
{
    public class Election
    {
        public int ElectionId { get; set; }
        private string name;
        private string question;
        private List<ElectionOption> voteElements;
        private List<Voter> voters;

        public Election(int id, string name, string question)
        {
            this.ElectionId = id;
            this.Name = name;
            this.question = question;
            this.VoteElements = new List<ElectionOption>();
            voters = new List<Voter>();
        }

        public string Question { get => question; set => question = value; }
        public string Name { get => name; set => name = value; }
        internal List<ElectionOption> VoteElements { get => voteElements; set => voteElements = value; }
        internal List<Voter> Voters { get => voters; set => voters = value; }

        public void AddOption(VoteElement Person)
        {
            ElectionOption voteElement = new ElectionOption(Person);
            voteElements.Add(voteElement);
        }

        public string Winner
        {
            get
            {
                string winner = "";
                int temp = 0;
                foreach (ElectionOption voteElement in voteElements)
                {
                    if (voteElement.VoteCounter > temp)
                    {
                        temp = voteElement.VoteCounter;
                        winner = voteElement.VoteElement.Text;
                    }
                }
                return winner;
            }
        }

        public void AddVoter(Voter voter)
        {
            voters.Add(voter);
        }

        public bool VoterVoted(Voter person)
        {
            foreach (Voter voter in voters)
            {
                if (voter.UserName == person.UserName)
                {
                    return true;
                }
            }
            return false;
        }

        public void Voting(Voter voter, string text)
        {
            voters.Add(voter);
            foreach (ElectionOption option in voteElements)
            {
                if (option.VoteElement.Text == text)
                    option.VoteCounter += 1;
            }
        }
    }
}