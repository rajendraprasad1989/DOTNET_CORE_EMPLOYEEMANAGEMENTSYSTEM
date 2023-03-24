using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebNetCoreAPIClass9.Data;
using WebNetCoreAPIClass9.Data.Repositories;
using WebNetCoreAPIClass9.Models;

namespace WebNetCoreAPIClass9
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
            services.AddDbContext<EMSContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EMSContext")));
            services.AddSpaStaticFiles(configuration => {
                configuration.RootPath = "FrontEnd/dist";
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Swashbuckle.AspNetCore.Swagger.Info
                {
                    Version = "v1",
                    Title = "API"
                });
            });
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeTestRepository, EmployeeTestRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Developement API");
                });
            }
            else
            {
                app.UseHsts();
                    app.UseDefaultFiles();
                    app.UseStaticFiles();
            }
            app.UseCors(builder => builder
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowAnyOrigin()
              .AllowCredentials()
              );
            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSpaStaticFiles();
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "FrontEnd";
            });
        }
    }
}
