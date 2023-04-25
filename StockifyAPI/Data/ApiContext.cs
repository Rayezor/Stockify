using Microsoft.EntityFrameworkCore;
using StockifyAPI.Models;

namespace StockifyAPI.Data
{
    public class ApiContext:DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        { }
    }
}
