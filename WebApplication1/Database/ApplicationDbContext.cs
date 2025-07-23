using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;

namespace WebApplication1.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Example table:

    }
}