using DefaultNamespace;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace netcore_webapp.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        // each thing we want as a table we need to specify as a db set property
        public DbSet<Pie> Pies { get; set; }
    }
}