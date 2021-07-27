namespace PetCare.Infrastructure
{
    using System.Linq;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using PetCare.Data;
    using PetCare.Data.Models.Employee;
    using PetCare.Data.Models.Pet;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
              this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<PetCareDbContext>();

            data.Database.Migrate();

            SeedCategories(data);
            SeedPositions(data);
            SeedGenders(data);

            return app;
        }

        private static void SeedCategories(PetCareDbContext data)
        {
            if (data.Animals.Any())
            {
                return;
            }

            data.Animals.AddRange(new[]
            {
                new AnimalType { Type = "Dog" },
                new AnimalType { Type = "Cat" },
                new AnimalType { Type = "Parrot" },
                new AnimalType { Type = "Rabit" },
                new AnimalType { Type = "Horse" },
                new AnimalType { Type = "Cow" },
                new AnimalType { Type = "Snake" },
            });

            data.SaveChanges();
        }

        private static void SeedPositions(PetCareDbContext data)
        {
            if (data.Positions.Any())
            {
                return;
            }

            data.Positions.AddRange(new[]
            {
                new Position { EmployeePosition  = "Doctor"},
                new Position { EmployeePosition  = "Nurse"},
                new Position { EmployeePosition  = "Administrator"},
            });

            data.SaveChanges();
        }

        private static void SeedGenders(PetCareDbContext data)
        {
            if (data.Genders.Any())
            {
                return;
            }

            data.Genders.AddRange(new[]
            {
                new Gender { GenderType = "Male"},
                new Gender { GenderType = "Female"}
            });

            data.SaveChanges();
        }

        private static void SeedCity(PetCareDbContext data)
        {
            //if (data.City.Any())
            //{
            //    return;
            //}

            //data.City.AddRange(new[]
            //{
            //    new City { Name = "Sofia"},
            //    new City { Name = "Plovdiv"},
            //    new City { Name = "Varna"},
            //});

            //data.SaveChanges();
        }
    }
}
