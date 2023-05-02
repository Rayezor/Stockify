using Microsoft.EntityFrameworkCore;
using Stockify.Models;

namespace Stockify.Data
{
    public class StockifyContext : DbContext
    {
        private const string StockifyConnectionString = "Server=tcp:stockifydbserver.database.windows.net,1433;Initial Catalog=Stockify_db;Persist Security Info=False;User ID=stockifyUser;Password=Stockify!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Crypto> Cryptos { get; set; }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StockifyConnectionString);

        }

    }
}
