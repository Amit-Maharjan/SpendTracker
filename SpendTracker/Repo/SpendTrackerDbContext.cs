using Microsoft.EntityFrameworkCore;
using SpendTracker.Models;

namespace SpendTracker.Repo;

public class SpendTrackerDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    public SpendTrackerDbContext(DbContextOptions<SpendTrackerDbContext> options) : base(options)
    {
            
    }
}
