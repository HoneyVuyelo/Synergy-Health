using Synergy_Health.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Synergy_Health.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HospitalInfo> businessInfos { get; set; }
        public DbSet<Vital> vitals { get; set; }
    }
}
