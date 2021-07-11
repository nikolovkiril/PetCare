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

            return app;
        }

        private static void SeedCategories(PetCareDbContext data)
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

            if (data.Animals.Any())
            {
                return;
            }

            data.Animals.AddRange(new[]
            {
                new AnimalType { Type = "N/A" },
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
    }
}
