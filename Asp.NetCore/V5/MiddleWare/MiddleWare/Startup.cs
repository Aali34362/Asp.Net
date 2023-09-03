using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWare
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        //Its not a mandatory Method
        /*public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }*/

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //Its a mandatory Method
        /* public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
         {
             if (env.IsDevelopment())
             {
                 app.UseDeveloperExceptionPage();
             }
             else
             {
                 app.UseExceptionHandler("/Error");
                 // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                 app.UseHsts();
             }

             app.UseHttpsRedirection();
             app.UseStaticFiles();

             app.UseRouting();

             app.UseAuthorization();

             app.UseEndpoints(endpoints =>
             {
                 endpoints.MapRazorPages();
             });
         }*/

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ConsoleLoggerMiddleware>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //The middleware is handling all the request coming to application and responding back with Hello World
            //This piece of code is refered as Request Delegate in asp.net middleware
            //In particular this is an example of inline middleware because we have written inline in the startup class
            //Request Delegates or middleware can be configured in 3 main methods

            //2. app.Use()
            /*app.Use(async (context, next) => 
            { 
                Console.WriteLine("Before Request");
                await next(); 
                Console.WriteLine("After Request"); 
            });*/
            app.UseMiddleware<ConsoleLoggerMiddleware>();
            //For Use() it takes context and next parameter. We have chained the


            app.Run(async context => {
                Console.WriteLine("Hello World");
                await context.Response.WriteAsync("Hello World");
            });
            //1. app.Run() -> it recieve only a context parameter it doesnt know about next/other delegate this delegate are also known as terminal delegates
            //because it terminates or ends the middleware pipeline. It is more of the convention to use Run() to indicate that it is end of the pipeline.

            //This not going to invoke the first one terminates the old pipeline
            app.Run(async context => await context.Response.WriteAsync("Hello again"));


            
            //3. app.Map() -> Branches the Request pipeline based on matches of the given request path starts with the given path, the branch is executed.


        }
    }
}
