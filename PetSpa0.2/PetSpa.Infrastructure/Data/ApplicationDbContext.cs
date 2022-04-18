using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetSpa.Infrastructure.Data.Identity;

namespace PetSpa.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Salon> Salons { get; set; }
        public DbSet<SalonService> SalonServices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<SalonService>(e =>
            {
                e.HasKey(a => new { a.SalonId, a.ServiceId });
            });

            builder.Entity<Appointment>(e =>
            {
                e.HasKey(a => new { a.SalonId, a.ServiceId });
            });
        }

    }
}