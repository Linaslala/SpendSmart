using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SpendSmartDbContext : DbContext
    {
        //property
        public DbSet<Expense> Expenses { get; set; }

        //konstruktor
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options)
            : base(options)
        {
            
        }
    }
}
