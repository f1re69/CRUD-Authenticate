using CRUD_Authenticate.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Authenticate.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("\nAUTHENTIFICATION\n");
            optionsBuilder.UseSqlServer("Server=(localdb)\\FR-L3X9M2J3\\SQLSERVER2;Database=customersdb;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
