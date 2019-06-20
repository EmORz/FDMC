using FDMC.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FDMC.Data.Data
{
    public class FdmcDbContext : IdentityDbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public FdmcDbContext(DbContextOptions<FdmcDbContext> options)
            : base(options)
        {
        }
    }
}
