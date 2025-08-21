using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
	public class StudentDbContext : DbContext
	{
        public StudentDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}