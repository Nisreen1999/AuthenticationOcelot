using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Course.Models
{
    public class ContextClass : DbContext
    {
        public DbSet<Course> course { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data Source=(local);initial catalog=testApi;Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
