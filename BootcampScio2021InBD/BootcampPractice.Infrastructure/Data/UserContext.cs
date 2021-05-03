using BootcampPractice.Infrastructure.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace BootcampPractice.Infrastructure.Data
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
