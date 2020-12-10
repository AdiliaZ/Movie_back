using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Movie_Back.Models;
using System.Text.Json;
using Movie_back.Pages.SessionExt;

namespace Movie_back
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
            services.AddMvc();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".MyApp.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
                options.Cookie.IsEssential = true;
            });
        }
    
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSession();   // добавляем механизм работы с сессиями
            /*app.Run(async (context) =>
            {
                 string login;
                 if (context.Request.Cookies.TryGetValue("name", out login))
                 {
                     await context.Response.WriteAsync($"Hello {login}!");
                 }
                 else
                 {
                     context.Response.Cookies.Append("name", "Tom");
                     await context.Response.WriteAsync("Hello World!");
                 }
                if (context.Session.Keys.Contains("user"))
                {
                    
                    User user  = context.Session.Get<User>("user");
                    await context.Response.WriteAsync($"Hello {user.Name}!");
                }
                else
                {
                    User user = new User { Name = "Tom" };
                    context.Session.Set<User>("person", user);
                    await context.Response.WriteAsync("Hello World!");
                }
            });*/
           

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
        }
    }
}
