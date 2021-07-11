﻿namespace PetCare.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using PetCare.Data.Models.Employe;
    using PetCare.Data.Models.Pet;

    public class PetCareDbContext : IdentityDbContext
    {
        public PetCareDbContext(DbContextOptions<PetCareDbContext> options)
            : base(options)
        {
        }

        public DbSet<AnimalType> Animals { get; init; }
        public DbSet<Pet> Pets { get; init; }
        public DbSet<Position> Positions { get; init; }
        public DbSet<Employe> Employes { get; init; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Pet>()
                .HasOne(a => a.AnimalType)
                .WithMany(p => p.Pets)
                .HasForeignKey(a => a.AnimalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Employe>()
                .HasOne(p => p.Position)
                .WithMany(e => e.Employes)
                .HasForeignKey(p => p.PositionId)
                .OnDelete(DeleteBehavior.Restrict);


            base.OnModelCreating(builder);
        }
    }
}
