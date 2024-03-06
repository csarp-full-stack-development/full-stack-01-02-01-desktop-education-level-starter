using Kreta.Shared.Models;
using Kreta.Shared.Models.SchoolCitizens;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public KretaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationLevel>()
                .HasMany(el => el.Students)
                .WithOne(s => s.EducationLevel)
                .HasForeignKey(s => s.EducationLevelId)
                .IsRequired(false);
        }
    }
}
