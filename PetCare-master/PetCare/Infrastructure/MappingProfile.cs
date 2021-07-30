namespace PetCare.Infrastructure
{
    using AutoMapper;
    using PetCare.Data.Models.Employee;
    using PetCare.Data.Models.Pet;
    using PetCare.Services.Employees.Models;
    using PetCare.Services.Pets.Models;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Pet
            this.CreateMap<Pet, PetDetailsServiceModel>()
                .ForMember(p => p.Animal , cfg => cfg.MapFrom(p => p.Animal.AnimalType))
                .ForMember(p => p.GenderType, cfg => cfg.MapFrom(p => p.GenderType.GenderType));

            this.CreateMap<Animal, AnimalTypeServiceModel>();
            this.CreateMap<Gender, GenderTypeServiceModel>();

            //Employee
            this.CreateMap<Employee, EmployeeDetailsServiceModel>()
                .ForMember(e => e.Position, cfg => cfg.MapFrom(e => e.Position.EmployeePosition));

            this.CreateMap<Position, PositionTypeServiceModel>();


        }
    }
}
