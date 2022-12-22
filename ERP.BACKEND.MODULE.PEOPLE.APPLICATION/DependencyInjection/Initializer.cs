namespace PeopleManagement.Application.DependencyInjection
{
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Application.Services;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using PeopleManagement.Domain.Interfaces.Services;
    using PeopleManagement.Domain.Services;
    using PeopleManagement.Infra.Contexts;
    using PeopleManagement.Infra.Repositories;
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
