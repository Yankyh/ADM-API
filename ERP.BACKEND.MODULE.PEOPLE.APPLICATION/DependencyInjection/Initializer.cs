using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.Services;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Services;
using ERP.BACKEND.MODULE.PERSON.INFRA.Contexts;
using ERP.BACKEND.MODULE.PERSON.INFRA.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.DependencyInjection
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));

            //Aplicação
            services.AddScoped(typeof(IApplicationBase<,>), typeof(ServiceApplicationBase<,>));
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
