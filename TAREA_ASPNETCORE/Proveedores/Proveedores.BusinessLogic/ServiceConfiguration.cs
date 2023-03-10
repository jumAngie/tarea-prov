using Microsoft.Extensions.DependencyInjection;
using Proveedores.BusinessLogic.Services;
using Proveedores.DataAccess;
using Proveedores.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proveedores.BusinessLogic
{
    public static class ServiceConfiguration
    {
        public static void DataAccess(this IServiceCollection services, string connection)
        {
            services.AddScoped<ProveedoresRepository>();
            EmpresaContext.BuildConnectionString(connection);
        }


        public static void BussinessLogic(this IServiceCollection services)
        {
            services.AddScoped<GeneralesService>();

        }
    }
}
