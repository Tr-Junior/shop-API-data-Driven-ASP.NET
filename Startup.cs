using Microsoft.Extensions.Configuration;
namespace shop
{
    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }

}