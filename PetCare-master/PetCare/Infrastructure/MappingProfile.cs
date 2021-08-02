namespace PetCare.Infrastructure
{
    using AutoMapper;
    using PetCare.Data.Models.Employee;
    using PetCare.Data.Models.Pet;
    using PetCare.Data.Models.VetService;
    using PetCare.Services.VetService.Models;
    using PetCare.Services.Employee.Models;
    using PetCare.Services.Pet.Models;
    using PetCare.Services.Clinics.Models;
    using PetCare.Data.Models.Clinic;
    using PetCare.Services.Clinic.Models;

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

            //VetServices
            this.CreateMap<VetService, AllVetServiceServiceModel>(); 
            this.CreateMap<VetService, VetServiceDetailsServiceModel>();

            //Clinic
            this.CreateMap<City, CityNameServiceModel>();
            this.CreateMap<Clinic, AllClinicsServiceModel>()
                .ForMember(c => c.CityName , cfg => cfg.MapFrom(c => c.City.Name));
        }
    }
}
