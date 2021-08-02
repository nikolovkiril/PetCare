namespace PetCare.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PetCare.Data.Models.Clinic;
    using PetCare.Data.Models.Employee;
    using PetCare.Data.Models.Pet;
    using PetCare.Data.Models.User;
    using PetCare.Data.Models.VetService;

    public class PetCareDbContext : IdentityDbContext<User>
    {
        public PetCareDbContext(DbContextOptions<PetCareDbContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; init; }
        public DbSet<Pet> Pets { get; init; }
        public DbSet<Position> Positions { get; init; }
        public DbSet<Employee> Employees { get; init; }
        public DbSet<VetService> VetServices { get; init; }
        public DbSet<Owner> Owners { get; init; }
        public DbSet<Gender> Genders { get; init; }
        public DbSet<City> Cities { get; init; }
        public DbSet<Clinic> Clinics { get; init; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Pet>()
                .HasOne(a => a.Animal)
                .WithMany(p => p.Pets)
                .HasForeignKey(a => a.AnimalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Pet>()
                .HasOne(g => g.GenderType)
                .WithMany(p => p.Pets)
                .HasForeignKey(g => g.GenderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Pet>()
                .HasOne(p => p.Owner)
                .WithMany(o => o.Pets)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Owner>()
                .HasOne<User>()
                .WithOne()
                .HasForeignKey<Owner>(o => o.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Employee>()
                .HasOne(p => p.Position)
                .WithMany(e => e.Employees)
                .HasForeignKey(p => p.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Entity<Clinic>()
               .HasOne(p => p.City)
               .WithMany(e => e.Clinics)
               .HasForeignKey(p => p.CityId)
               .OnDelete(DeleteBehavior.Restrict);
           

            base.OnModelCreating(builder);
        }
    }
}
