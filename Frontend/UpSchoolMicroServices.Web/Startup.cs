using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolECommerce.Shared.Services;
using UpSchoolMicroServices.Web.Models;
using UpSchoolMicroServices.Web.Services.Abstract;
using UpSchoolMicroServices.Web.Services.Concrete;

namespace UpSchoolMicroServices.Web
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
            services.AddHttpClient<IClientCredentialTokenService, ClientCredentialTokenService>();
            services.Configure<ClientSettings>(Configuration.GetSection("ClientSettings"));
            var servicesApiSettings=Configuration.GetSection("ServicesApiSettings").Get<ServicesApiSettings>();
            services.Configure<ServicesApiSettings>(Configuration.GetSection("ServicesApiSettings"));
            services.AddHttpContextAccessor();
            services.AddScoped<ISharedIdentityService, SharedIdentityService>();
            services.AddHttpClient<ICategoryService, CategoryService>(opt => {
                opt.BaseAddress = new Uri($"{servicesApiSettings.GateWayBaseUrl}/{servicesApiSettings.Catalog.Path}");
            });
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
