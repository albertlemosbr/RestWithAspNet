using Microsoft.EntityFrameworkCore;

namespace RestWithAspNetCore.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
            
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Person> People { get; set; }
    }
}