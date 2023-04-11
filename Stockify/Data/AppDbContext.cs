/*using Microsoft.EntityFrameworkCore;
using Stockify.Models;

namespace Stockify.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Crypto> Cryptos { get; set; }
        private const string connectionString = "Server=tcp:stockifyserver.database.windows.net,1433;Initial Catalog=Stockify_db;Persist Security Info=False;User ID=rayzor1394;Password={Kene&Ray0905};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"; // Stockify in users rayezor folder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
*/