using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using dotnet_web.models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DatabaseContext>(options =>
                  
                    options.UseNpgsql(
            "Host=ec2-54-83-9-36.compute-1.amazonaws.com;" +
            "Database=d76dvfemdvq3b4;Username=tthuzzuumpwkry;"+
            "Password=2b01c50438365ab95cc5496c0c580a594865bb02ede03ace69e9d263081aa2f0;"+
            "Port=5432;SSL Mode=Require;Trust Server Certificate=true")
                  ); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles(); // For the wwwroot folder
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            /* app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/

            app.UseMvc(routes => {

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
