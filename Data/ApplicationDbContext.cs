using CalculatorBMI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalculatorBMI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}
