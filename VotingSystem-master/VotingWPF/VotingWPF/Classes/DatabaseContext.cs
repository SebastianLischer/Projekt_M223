using System.Data.Entity;

namespace VotingWPF.Classes
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=M223ConnectionString")
        {
        }

        public DbSet<Admin> Administrator { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VoteElement> VoteElements { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<ElectionOption> ElectionOptions { get; set; }
        public DbSet<Voter> Voters { get; set; }
    }
}