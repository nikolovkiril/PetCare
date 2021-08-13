namespace PetCare.Test.Mocks
{
    using AutoMapper;
    using PetCare.Infrastructure;

    public static class MapperMock
    {
        public static IMapper Instance
        {
            get
            {
                var mapperConfig = new MapperConfiguration(config =>
                {
                    config.AddProfile<MappingProfile>();
                });

                return new Mapper(mapperConfig);
            }
        }
    }
}
