using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TruckTracking.API.Models;
using TruckTracking.API.Repositories;
namespace TruckTracking.API
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
                // services.AddControllers();
                // services.AddDbContext<TransportContext>(opt =>
                //     opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<TransportContext>(opt =>
               opt.UseNpgsql(Configuration.GetConnectionString("PostgreConnection")));
            //   services.AddDbContext<TransportContext>(opt =>
            //         opt.UseSqlite("Filename=./dummy.db"));
            services.AddScoped<ITransRepository,TransRepository>();
            services.AddCors();  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
 

            app.UseRouting();

            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
