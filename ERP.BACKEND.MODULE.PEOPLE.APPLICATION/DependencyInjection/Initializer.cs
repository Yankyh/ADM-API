namespace Erp.Backend.Module.PERSON.APPLICATION.DependencyInjection
{
    using Erp.Backend.Module.PERSON.APPLICATION.Interfaces;
    using Erp.Backend.Module.PERSON.APPLICATION.Services;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services;
    using Erp.Backend.Module.PERSON.DOMAIN.Services;
    using Erp.Backend.Module.PERSON.INFRA.Contexts;
    using Erp.Backend.Module.PERSON.INFRA.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));

            //Aplicação
            services.AddScoped(typeof(IApplicationBase<,,>), typeof(ServiceApplicationBase<,,>));
            services.AddScoped<IPersonApplication, PersonApplication>();
            services.AddScoped<IUserApplication, UserApplication>();

            //Domínio
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IUserService, UserService>();

            //Repositorio
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
