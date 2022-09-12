using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocorrencia_API.Configurations;

namespace Ocorrencia_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //configurações da api
            services.AddApiConfiguration(Configuration);

            //swagger
            services.AddSwaggerConfiguration();

            //injeção de dependência
            services.RegisterServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //configurações da api
            app.UseApiConfiguration(env);
            
            //swagger
            app.UseSwaggerConfiguration();
        }
    }
}
