using ProjektPK.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VotingWPF.Classes;


namespace VotingWPF.Service
{
    class VoteElementService
    {
        private Repository<VoteElement> voteElementRepository;

        public VoteElementService()
        {
            this.voteElementRepository = new Repository<VoteElement>();

            VoteElement voteElement1 = new VoteElement("test");
            voteElement1.Id = 1;
            voteElementRepository.addElement(1, voteElement1);
        }
        public bool FindVoteElementByUsername(string text)
        {
            List<VoteElement> voteElements = voteElementRepository.getAll();
            foreach(VoteElement voteElement in voteElements)
            {
                if(voteElement.Text == text)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReturnTrueIfElementNew(string text)
        {
            List<VoteElement> voteElements = voteElementRepository.getAll();
            foreach (VoteElement voteElement in voteElements)
            {
                if (voteElement.Text == text)
                {
                    return true;
                }
            }
            return false;
        }



        public void AddVoteElement(string text)
        {
            if (FindVoteElementByUsername(text) == false)
            {
                VoteElement voteElement = new VoteElement(text);
                int id = voteElementRepository.getLastId() + 1;
                voteElement.Id = id;
                voteElementRepository.addElement(id, voteElement);
            }
            else
            {
                throw new Exception("Choose other username, please");
            }
        }




        internal Repository<VoteElement> VoteElementRepository { get => voteElementRepository; set => voteElementRepository = value; }
    }
}