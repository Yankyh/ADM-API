using ERP.BACKEND.MODULE.PEOPLE.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PEOPLE.APPLICATION.Services;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Services;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Services;
using ERP.BACKEND.MODULE.PEOPLE.INFRA.Contexts;
using ERP.BACKEND.MODULE.PEOPLE.INFRA.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.APPLICATION.DependencyInjection
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conection));
          //  services.AddScoped(typeof(IRepository<Person>), typeof(PersonRepository));
           // services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped(typeof(PersonService));

            //Aplicação
            services.AddScoped(typeof(IApplicationBase<,>), typeof(ServiceApplicationBase<,>));
            services.AddScoped<IPersonApplication, PersonApplication>();

            //Domínio
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IPersonService, PersonService>();

            //Repositorio
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IPratoRepositorio, PratoRepositorio>();
        }
    }
}
