using MediatR;
using Serilog;
using CalculatorInterview.BLL;
using CalculatorInterview.Mapping;

namespace CalculatorInterview
{
    public class Startup
    {
        private readonly IConfigurationRoot configuration;
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            this.configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMediatR(typeof(Startup));
            services.AddLogicServices(configuration);
            services.AddAutoMapper(typeof(DtoProfiles));
            services.AddHttpContextAccessor();           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            Log.Logger = new LoggerConfiguration()
                    .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Month)
                    .CreateLogger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseMiddleware<ExceptionMiddleware>();        

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
           
        }
    }
}
