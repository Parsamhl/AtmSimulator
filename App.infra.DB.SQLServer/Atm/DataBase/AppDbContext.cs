using App.infra.DB.SQLServer.Atm.Configuration.Card;
using App.infra.DB.SQLServer.Atm.Configuration.Transaction;
using App.infra.DB.SQLServer.Atm.Configuration.User;
using Microsoft.EntityFrameworkCore;


namespace App.infra.DB.SQLServer.Atm.DataBase
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Hw15;Integrated Security=SSPI;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Domain.Core.Atm.User.Entities.User> Users { get; set; }
        public DbSet<Domain.Core.Atm.Transaction.Entities.Transaction> Transactions { get; set; }
        public DbSet<Domain.Core.Atm.Card.Entities.Card> cards { get; set; }
    }
}

