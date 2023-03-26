using ProjektPK.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using VotingWPF.Classes;
using VotingWPF.Repositoriy;

namespace VotingWPF.Service
{
    class VoterService
    {
        private Repository<Voter> voterRepository;

        public VoterService()
        {
            this.VoterRepository = new Repository<Voter>();
        }

        internal Repository<Voter> VoterRepository { get => voterRepository; set => voterRepository = value; }

        
        public Voter Login(string username,string password)
        {
            //Check if voter exists
            if (UserRepository.AuthenticateUser(new NetworkCredential(username, password)))
            {
                //Create Voter
                Voter voter = new Voter() { UserName = username, Password = password };
                return voter;
            }
            return null;
        }

        public bool AddVoter(string username, string password, string name, string lastname, int age, string adminPassword)
        {
            if(UserRepository.FindVoterByUsername(username)==false)
            {
                int admin = 0;
                if (adminPassword == "admin")
                {
                    admin = 1;
                }
                using (var ctx = new DatabaseContext())
                {
                    Voter voter = new Voter(username, password, name, lastname, age, admin);
                    ctx.Voters.Add(voter);
                    ctx.SaveChanges();
                    return true;
                }
            }
            else{
                MessageBox.Show("Your username is already used", "Eroor",MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}