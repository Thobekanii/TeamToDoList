using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Assignee> assignees { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Task> tasks { get; set; }

    }
}
