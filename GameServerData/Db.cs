using Microsoft.EntityFrameworkCore;
using GameServerData.Models;

namespace GameServerData
{
    public class Db : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public Db(DbContextOptions<Db> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasData(new Account()
            {
                Id = 1,
                Login = "Marikuana",
                Password = "123",
                Email = "Marikuana@gmail.com"
            });
        }
    }
}