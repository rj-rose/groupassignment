using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using groupassignment.Models;

namespace groupassignment
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(45);

            });
            services.AddRouting(options =>
                {
                    options.AppendTrailingSlash = true;
                    options.LowercaseUrls = true;
                });

            services.AddDbContext<OurDbContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("OurDbContext")));
        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            

            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                /*  // map route for Admin area
                  endpoints.MapAreaControllerRoute(
                      name: "admin",
                      areaName: "Admin",
                      pattern: "Admin/{controller=Home}/{action=Login}/{id?}");

                  map default route*/
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");

                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "{controller=Home}/{action=Login}");


                endpoints.MapControllerRoute(
                    name: "register",
                    pattern: "{controller=Home}/{action=Register}");

                endpoints.MapControllerRoute(
                    name: "main",
                    pattern: "{controller=Main}/{action=Details}");


            });
        }
    }
}