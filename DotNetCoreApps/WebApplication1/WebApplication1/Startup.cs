using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        private IHostingEnvironment _env;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _env = hostingEnvironment;
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                //.AddJsonFile("appsettings.json") //development, production, stage
                .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", true)
                //.AddEnvironmentVariables();
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            //services.AddTransient<ITradeRepository, TradeRepository>();
            services.AddTransient<ICategoryRepository, MockCategoryRepository>();
            services.AddTransient<ITradeRepository, MockTradeRepository>();

            services.AddSingleton(_configurationRoot);
            if (_env.IsEnvironment("Development") || _env.IsEnvironment("Production") || _env.IsEnvironment("Stage"))
            {
                services.AddScoped<IMailService, DebugMailService>(); //scope of a single request
            }
            else   { }  // Implement a real Mail Service
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/AppException");
            }
            app.UseStatusCodePages();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            //app.UseMvc(pp =>
            //{
            //    pp.MapRoute(name: "fg", template: "{controller}/bsr/gt{rt?}",
            //        defaults: new {controller = "App", action = "Index"})
            //});
            //DbInitializer.Seed(app);
        }
    }
}
