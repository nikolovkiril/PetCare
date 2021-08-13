namespace PetCare.Test.Mocks
{
    using Microsoft.EntityFrameworkCore;
    using PetCare.Data;

    public static class DatabaseMock
    {
        public static PetCareDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<PetCareDbContext>()
                    .UseInMemoryDatabase("TestDb")
                    .Options;

                return new PetCareDbContext(dbContextOptions);
            }
        }
    }
}
