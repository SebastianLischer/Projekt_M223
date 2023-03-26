namespace VotingWPF.Classes
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string userName;
        public string password;

        public Admin()
        {
            this.userName = "admin";
            this.password = "";
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}