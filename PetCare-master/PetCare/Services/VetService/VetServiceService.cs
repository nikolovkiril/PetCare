namespace PetCare.Services.VetService
{
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using PetCare.Data;
    using PetCare.Data.Models.VetService;
    using PetCare.Services.VetService.Models;
   

    public class VetServiceService : IVetServiceService
    {
        private readonly PetCareDbContext data;
        private readonly IMapper mapper;

        public VetServiceService(
            PetCareDbContext data, 
            IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public void NewVetService(
            string description, 
            string imgUrl, 
            string serviceName)
        {
            var service = new VetService
            {
                Description = description,
                ImgUrl = imgUrl,
                ServiceName = serviceName
            };

            this.data.VetServices.Add(service);

            this.data.SaveChanges();
        }

        public IEnumerable<AllVetServiceServiceModel> VetServiceAll()
            => this.data
                .VetServices
                .ProjectTo<AllVetServiceServiceModel>(this.mapper.ConfigurationProvider)
                .OrderByDescending(vs => vs.Id)
                .ToList();

        public bool VetServiceAny(int vetServiceId)
            => this.data
                .VetServices
                .Any(vs => vs.Id == vetServiceId);


        public VetServiceDetailsServiceModel Details(int vetServiceId)
            => this.data
                 .VetServices
                 .Where(vs => vs.Id == vetServiceId)
                 .ProjectTo<VetServiceDetailsServiceModel>(this.mapper.ConfigurationProvider)
                 .FirstOrDefault();

        public bool Edit(int vetId, string serviceName, string description, string imgUrl)
        {
            var vetService = this.data.VetServices.Find(vetId);

            if (vetService == null)
            {
                return false;
            }

            vetService.ServiceName = serviceName;
            vetService.Description = description;
            vetService.ImgUrl = imgUrl;

            this.data.SaveChanges();

            return true;
        }

        public bool Delete(int vetId)
        {
            var vet = this.data
                .VetServices
                .Find(vetId);

            if (vet == null)
            {
                return false;
            }

            this.data.VetServices.Remove(vet);

            this.data.SaveChanges();

            return true;
        }
    }
}
