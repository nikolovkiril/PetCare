namespace PetCare.Services.Clinic
{
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using PetCare.Data;
    using PetCare.Services.Clinics.Models;
    using PetCare.Data.Models.Clinic;
    using PetCare.Services.Clinic.Models;

    public class ClinicService : IClinicService
    {
        private readonly PetCareDbContext data;
        private readonly IMapper mapper;

        public ClinicService(
            PetCareDbContext data,
            IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public void CreateClinic(
            string name, 
            string street, 
            int cityId, 
            string phoneNumber)
        {
            var clinic = new Clinic
            {
                Name = name,
                Street = street,
                CityId = cityId,
                PhoneNumber = phoneNumber
            };

            this.data.Clinics.Add(clinic);

            this.data.SaveChanges();
        }

        public IEnumerable<CityNameServiceModel> GetCityNames()
            => this.data
                    .Cities
                    .ProjectTo<CityNameServiceModel>(this.mapper.ConfigurationProvider)
                    .ToList();

        public bool IsCityExist(int CityId)
            => this.data
                .Cities
                .Any(c => c.Id == CityId);



        public IEnumerable<AllClinicsServiceModel> All()
            => this.data
                .Clinics
                .ProjectTo<AllClinicsServiceModel>(this.mapper.ConfigurationProvider)
                .OrderByDescending(c => c.CityName.StartsWith("S"))
                .ThenBy(x => x.Name)
                .ToList();
    }
}
