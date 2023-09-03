using Microsoft.EntityFrameworkCore;
using ModelsDB;

namespace DietDB
{
    public class DietContext : DbContext
    {
        public DietContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Example> Examples { get; set; }
    }
}
