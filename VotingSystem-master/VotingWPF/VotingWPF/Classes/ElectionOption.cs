using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    public class ElectionOption
    {
        public int ElectionOptionID { get; set; }
        VoteElement voteElement;
        int voteCounter;
        public ElectionOption(VoteElement voteElement)
        {
            this.VoteElement = voteElement;
            this.VoteCounter = 0;
        } 

        public int VoteCounter { get => voteCounter; set => voteCounter = value; }
        internal VoteElement VoteElement { get => voteElement; set => voteElement = value; }

        public void AddOne()
        {
            this.VoteCounter += 1;
        }
        
        public string VoteElementText { get { return voteElement.Text; } }
        public int VoteElementVotes { get { return voteCounter; } }
    }
}
