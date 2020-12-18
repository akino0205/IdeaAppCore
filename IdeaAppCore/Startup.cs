using IdeaAppCore.Areas.Identity;
using IdeaAppCore.Data;
using IdeaAppCore.Models;
using IdeaAppCore.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace IdeaAppCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSingleton<WeatherForecastService>();

            services.AddTransient<IIdeaRepository, IdeaRepository>();

            //[DI] InfoService 클래스 의존성 주입
            services.AddSingleton<InfoService>();

            //[DI] IInfoService 인터페이스 의존성 주입
            services.AddSingleton<IInfoService, InfoService>();

            //[옵션패턴]IOptionSnapshot, IOptionMonitor
            services.Configure<MyServiceOptions>(Configuration.GetSection(MyServiceOptions.MyService));

            //[옵션패턴]IConfigureNamedOptions
            services.Configure<MyServiceOptions>(MyServiceOptions.strArrOption, Configuration.GetSection($"{MyServiceOptions.MyService}:{MyServiceOptions.strArrOption}"));
            services.Configure<MyServiceOptions>(MyServiceOptions.strArrOption2, Configuration.GetSection($"{MyServiceOptions.MyService}:{MyServiceOptions.strArrOption2}"));

            //[CustomLog] ColorConsoleLoggerConfiguration 클래스 의존성 주입
            services.AddSingleton<ColorConsoleLoggerConfiguration>();
            services.AddSingleton<ILogger, ColorConsoleLogger>();

            //Generic Interface Ex
            //services.AddTransient<IDbService<TGroup, TGroup>, DbService>();
            //services.AddTransient<IDbService<GroupModel, GroupModel>, DbServiceWithModel>();

            //AppSetting Ex
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddSingleton<AppSettingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                logger.LogInformation("In Development.");
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                logger.LogInformation("Not Development.");
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
