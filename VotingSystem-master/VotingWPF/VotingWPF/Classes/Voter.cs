using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingWPF.Classes
{
    public class Voter : User
    {
        public int VoterID { get; set; }
        string name;
        string lastName;
        int age;

        public Voter(string userName, string password, string name, string lastName, int age, int admin) : base(userName, password, admin)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }

        public Voter() : base()
        {
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
    }
}
