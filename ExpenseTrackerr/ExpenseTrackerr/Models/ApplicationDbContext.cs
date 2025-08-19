using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        // the instance will create using dependency injection in program.cs file where we have to add the DbContext to the service collection and also specific we use sql server as the database provider and pass the connection string
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }

        
        public DbSet<Transaction> Transactions { get; set; } // here the table name will be Transactions 
        public DbSet<Category> Categories { get; set; } // here the table name will be Categories
    }
}
