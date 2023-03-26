using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VotingWPF.Service
{
    class DataBase
    {
        private static DataBase instance = null;

        private ElectionService electionService;
        private VoteElementService voteElementService;
        private VoterService voterService;


        public DataBase()
        {
                this.ElectionService = new ElectionService();
                this.voteElementService = new VoteElementService();
                this.voterService = new VoterService();
        }

        internal static DataBase Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataBase();
                }
                return instance;
            }
        }

        internal ElectionService ElectionService { get => electionService; set => electionService = value; }
        internal VoteElementService VoteElementService { get => voteElementService; set => voteElementService = value; }
        internal VoterService VoterService { get => voterService; set => voterService = value; }
    }
}
