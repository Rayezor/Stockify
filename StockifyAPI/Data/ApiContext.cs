using Microsoft.EntityFrameworkCore;
using StockifyAPI.Models;

namespace StockifyAPI.Data
{
    public class ApiContext:DbContext
    {
       
        
        // database connection string
        private const string StockifyConnectionString = "Server=tcp:stockifydbserver.database.windows.net,1433;Initial Catalog=Stockify_db;Persist Security Info=False;User ID=stockifyUser;Password=Stockify!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public DbSet<Company> Companies { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(StockifyConnectionString);

        }
    }
}
