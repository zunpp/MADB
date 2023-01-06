using Data.Models;
using Data.Repository;
using Data.Repository.Base;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MADB_API
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
            //services.AddControllers();
            services.AddMvcCore().AddVersionedApiExplorer(
                options =>
                {
                    options.GroupNameFormat = "'v'VVV";

                    // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
                    // can also be used to control the format of the API version in route templates
                    options.SubstituteApiVersionInUrl = true;
                });

            services.AddApiVersioning(o => o.AssumeDefaultVersionWhenUnspecified = true);

            services.AddDbContext<MADBSolutionContext>(opts =>
            {
                opts.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")//use geometry datatype
                );
            });
            //services.AddDbContext <MADBSolutionContext>
            //  (opt1ions => opt1ions.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
           

            services.AddMvc(); 
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<Services.Base.IUserServices, Services.UserServices>();
            services.Configure<Services.Options.ConnectionStrings>(Configuration.GetSection(nameof(Services.Options.ConnectionStrings)));
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

            });
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("AccessUser",
            //        policy => policy.Requirements.Add(new APIAuthorizationRequirement()));
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("CorsPolicy");
            app.UseAuthorization();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
