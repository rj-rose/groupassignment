using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace groupassignment.Models
{
    public class OurDbContext : DbContext
    {
        public OurDbContext(DbContextOptions<OurDbContext> options)
            : base(options)
        { }

        public DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserAccount>().HasData(

                new UserAccount {
                    Userid = Guid.NewGuid(),
                    Fname = "Rj", 
                    Lname = "Rose", 
                    Username = "Sonic3838", 
                    Password = "Gymnast22", 
                    Email = "rjrose2003@gmail.com" }

            );
        }
    }
}
