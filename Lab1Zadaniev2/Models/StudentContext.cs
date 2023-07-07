using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1Zadaniev2.Models
{
    public class StudentContext :  IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
}
