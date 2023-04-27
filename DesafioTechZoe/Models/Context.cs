
using Microsoft.EntityFrameworkCore;

namespace DesafioTechZoe.Models
{
    public class Context : DbContext
    {
        public DbSet<TaskModel> Tasks { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}

