using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Threading;
using VotingWPF.Classes;

namespace VotingWPF.Repositoriy
{
    public class UserRepository
    {
        private List<Voter> votersList;
        private List<VoteElement> voteElementsList;

        public UserRepository()
        {
            this.votersList = new List<Voter>();
            this.voteElementsList = new List<VoteElement>();
        }

        public int getLastVoterID()
        {
            Voter temp = new Voter();
            if (votersList.Count == 0)
            {
                return 0;
            }
            temp = votersList.Last();
            return temp.Id;
        }

        public List<VoteElement> getVoteElement()
        {
            return voteElementsList;
        }

        public List<Voter> getVoters()
        {
            return votersList;
        }

        //public int getLastvoteElementID()
        //{
        //    voteElement temp = new voteElement();
        //    if(voteElementsList.Count == 0)
        //    {
        //        return 0;
        //    }
        //    temp = voteElementsList.Last();
        //    return temp.Text;
        //}

        public void addVoter(Voter voter)
        {
            votersList.Add(voter);
        }

        public void addVoteElement(VoteElement voteElement)
        {
            voteElementsList.Add(voteElement);
        }

        public void deleteVoter(int idToFind)
        {
            Voter result = votersList.Find(
                delegate (Voter temp)
                {
                    return temp.Id == idToFind;
                }
             );
            if (result != null)
            {
                votersList.Remove(result);
            }
            else
            {
                throw new Exception("Could not find !");
            }
        }

        public void deleteVoteElement(int idToFind)
        {
            VoteElement result = voteElementsList.Find(
                delegate (VoteElement temp)
                {
                    return temp.Id == idToFind;
                }
             );
            if (result != null)
            {
                voteElementsList.Remove(result);
            }
            else
            {
                throw new Exception("Could not find !");
            }
        }

        public void loadVoterFromFile()
        {
            string fileName = @"";
            string line = "";

            StreamReader file = new StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                string[] userData = line.Split(' ');
                int id = 0;
                Int32.TryParse(userData[0], out id);
                Voter voter = new Voter();
            }
        }

        public void loadCandFromFile()
        {
            string fileName = @"";
            string line = "";

            StreamReader file = new StreamReader(fileName);
            while ((line = file.ReadLine()) != null)
            {
                string[] userData = line.Split(' ');
                int id = 0;
                Int32.TryParse(userData[0], out id);
            }
        }

        public static int DbCheckIfAdmin()
        {
            IPrincipal threadPrincipal = Thread.CurrentPrincipal;
            using (var ctx = new DatabaseContext())
            {
                //var students = ctx.Users.ToList<User>();
                var user = ctx.Users
                    .Where(s => s.UserName == threadPrincipal.Identity.Name)
                    .FirstOrDefault<User>();

                if (user != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static bool AuthenticateUser(NetworkCredential credential)
        {
            using (var ctx = new DatabaseContext())
            {
                //var students = ctx.Users.ToList<User>();
                var user = ctx.Voters
                    .Where(s => s.UserName == credential.UserName && s.Password == credential.Password)
                    .FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void SaveVoteElement(string text)
        {
            using (var ctx = new DatabaseContext())
            {
                var voteElement = new VoteElement(text);
                ctx.VoteElements.Add(voteElement);
                ctx.SaveChanges();
            }
        }

        public static bool FindVoterByUsername(string username)
        {
            using (var ctx = new DatabaseContext())
            {
                //var students = ctx.Users.ToList<User>();
                var user = ctx.Voters
                    .Where(s => s.UserName == username)
                    .FirstOrDefault();

                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}