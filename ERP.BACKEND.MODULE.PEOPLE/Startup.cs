using PeopleManagement.Application.DependencyInjection;
using PeopleManagement.Application.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PeopleManagement.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddAutoMapper(x => x.AddProfile(new EntityMapping()));
            Initializer.Configure(services, Configuration.GetConnectionString("DefaultConnection") ?? throw new Exception("Something went wrong when connecting to the db!"));
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
 
        }
    }
}
