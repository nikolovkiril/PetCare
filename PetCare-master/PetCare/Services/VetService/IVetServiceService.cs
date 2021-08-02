namespace PetCare.Services.VetService
{
    using System.Collections.Generic;
    using PetCare.Services.VetService.Models;

    public interface IVetServiceService
    {
        void NewVetService(
            string description,
            string imgUrl,
            string serviceName);

        IEnumerable<AllVetServiceServiceModel> VetServiceAll();

        bool VetServiceAny(int vetServiceId);

        VetServiceDetailsServiceModel Details(int vetServiceId);
    }
}
