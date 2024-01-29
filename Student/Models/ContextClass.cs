using Microsoft.EntityFrameworkCore;

namespace Student.Models
{
    public class ContextClass : DbContext
    {
        public DbSet<Student> student { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data Source=(local);initial catalog=testApi;Integrated Security=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
