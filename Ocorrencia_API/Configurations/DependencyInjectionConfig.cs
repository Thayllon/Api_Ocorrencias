using Microsoft.Extensions.DependencyInjection;
using Ocorrencia_API.Data.Context;
using Ocorrencia_API.Data.Repositories;
using Ocorrencia_API.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocorrencia_API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<AppDbContext>();
        }
    }
}
