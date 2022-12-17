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
          //  services.AddScoped(typeof(IRepository<People>), typeof(PeopleRepository));
           // services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScoped(typeof(PeopleService));

            //Aplicação
            services.AddScoped(typeof(IApplicationBase<,>), typeof(ServiceApplicationBase<,>));
            services.AddScoped<IPeopleApplication, PeopleApplication>();

            //Domínio
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            services.AddScoped<IPeopleService, PeopleService>();

            //Repositorio
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IPeopleRepository, PeopleRepository>();
            services.AddScoped<IPratoRepositorio, PratoRepositorio>();
        }
    }
}
