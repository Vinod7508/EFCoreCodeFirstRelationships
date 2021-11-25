using CodeFirstDatabaseMigration.Entities;
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

namespace CodeFirstDatabaseMigration
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
            services.AddControllers();


            //We are using the AddDbContext extension method to register our ApplicationContext class into the IOC container.
            //Inside the UseSqlSrver method we are providing the connection string to our context class and we can provide additional options as well. 
            services.AddDbContext<ApplicationContext>(opts =>
       opts.UseSqlServer(Configuration.GetConnectionString("SchoolConnection")));


          //Instead of the AddDbContext method, we can use the AddDbContextPool method. We can use either the first or the second method, but with the second method, we enable DbContext pooling.
          ////This will not create a new instance every time but will check first if there are available instances in the pool and if there are, it will use one of those



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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
