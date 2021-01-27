using Microsoft.EntityFrameworkCore;
using DdPortal.Models;

namespace DdPortal.Data
{
    public class MvcOfficeContext : DbContext
    {
        public MvcOfficeContext (DbContextOptions<MvcOfficeContext> options)
            : base(options)
        {
        }

        public DbSet<Office> Office { get; set; }
    }
}