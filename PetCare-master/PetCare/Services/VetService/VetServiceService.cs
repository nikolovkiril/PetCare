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

    }
}
