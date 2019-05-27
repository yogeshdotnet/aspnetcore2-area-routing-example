using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace Core_Basic
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapAreaRoute(
    name: "default",
    areaName: "Guest",
    template: "Guest/{controller}/{action}/{id?}",
    defaults: new { controller = "GuestLogin", action = "Index" });
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Login}/{action=Index}/{id?}"
                );
            });
          

            app.UseMvc(routes =>
            {
                routes.MapRoute("yogesh", CustomRouteHandler());
               
                routes.MapRoute(
                    name: "default3",
                    template: "MyHome/{controller=Student}/{action=Index}/{id:int?}"

                    );
                routes.MapRoute(
                    name: "default2",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" },
                    constraints: new { id = new IntRouteConstraint() }
                    );
              
            });


        }
        private static RequestDelegate CustomRouteHandler()
        {
            return async (c) =>
            {
                await Task.Run(() => c.Response.Redirect("https://yogeshdotnet.com"));
            };
        }
    }
}
