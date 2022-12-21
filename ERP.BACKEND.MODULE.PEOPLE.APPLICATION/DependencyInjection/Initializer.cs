namespace Backend.Module.PERSON.APPLICATION.DependencyInjection
{
    using Backend.Module.PERSON.APPLICATION.Interfaces;
    using Backend.Module.PERSON.APPLICATION.Services;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Services;
    using Backend.Module.PERSON.DOMAIN.Services;
    using Backend.Module.PERSON.INFRA.Contexts;
    using Backend.Module.PERSON.INFRA.Repositories;
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
