namespace PetCare.Test
{
    using MyTested.AspNetCore.Mvc;

    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;

    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) 
            : base(configuration)
        {
        }

        public void ConfigureTestServices(IServiceCollection services)
        {
            base.ConfigureServices(services);
        }
    }
}
