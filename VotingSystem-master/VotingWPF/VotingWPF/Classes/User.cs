namespace VotingWPF.Classes
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public int Admin{ get; set; } = 0;




        public User(string userName, string password, int admin)
        {
            this.UserName = userName;
            this.Password = password;
            this.Admin = admin;
        }

        public User()
        {
        }
    }
}