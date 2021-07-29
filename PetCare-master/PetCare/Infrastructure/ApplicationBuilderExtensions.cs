namespace PetCare.Infrastructure
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using PetCare.Data;
    using PetCare.Data.Models.Employee;
    using PetCare.Data.Models.Pet;
    using PetCare.Data.Models.User;

    using static WebConstants;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
              this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabese(services);

            SeedCategories(services);
            SeedPositions(services);
            SeedGenders(services);
            SeedAdministrator(services);

            return app;
        }

        private static void MigrateDatabese(IServiceProvider services)
        {
            var data = services.GetRequiredService<PetCareDbContext>();

            data.Database.Migrate();
        }

        private static void SeedCategories(IServiceProvider services)
        {
            var data = services.GetRequiredService<PetCareDbContext>();

            if (data.Animals.Any())
            {
                return;
            }

            data.Animals.AddRange(new[]
            {
                new Animal { AnimalType = "Dog" },
                new Animal { AnimalType = "Cat" },
                new Animal { AnimalType = "Parrot" },
                new Animal { AnimalType = "Rabit" },
                new Animal { AnimalType = "Horse" },
                new Animal { AnimalType = "Cow" },
                new Animal { AnimalType = "Snake" },
            });

            data.SaveChanges();
        }

        private static void SeedPositions(IServiceProvider services)
        {
            var data = services.GetRequiredService<PetCareDbContext>();

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

        private static void SeedGenders(IServiceProvider services)
        {
            var data = services.GetRequiredService<PetCareDbContext>();

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

        private static void SeedCity(IServiceProvider services)
        {
            var data = services.GetRequiredService<PetCareDbContext>();

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

        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministartorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministartorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@petcare.com";
                    const string adminPassword = "admin@petcare.com";

                    var user = new User
                    {
                        Email = adminEmail,
                        UserName = adminEmail,
                        NickName = "Admin"
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}
