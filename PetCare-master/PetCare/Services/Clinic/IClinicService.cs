namespace PetCare.Services.Clinic
{
    using System.Collections.Generic;
    using PetCare.Services.Clinic.Models;
    using PetCare.Services.Clinics.Models;

    public interface IClinicService
    {
        public IEnumerable<CityNameServiceModel> GetCityNames();
        bool IsCityExist(int CityId);

        void CreateClinic(
            string name,
            string street,
            int cityId,
            string phoneNumber);

        IEnumerable<AllClinicsServiceModel> All();
    }
}
