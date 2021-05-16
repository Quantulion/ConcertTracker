using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using DataLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace ConcertTracker
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
            services.AddRazorPages();
            string cs = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextFactory<ApplicationDbContext>(opt => opt.UseSqlServer(cs));
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(cs));
            services.AddServerSideBlazor();

            services.AddTransient<IAdminRepository, EFAdminRepository>();
            services.AddTransient<IArtistRepository, EFArtistRepository>();
            services.AddTransient<IUserRepository, EFUserRepository>();
            services.AddTransient<IConcertHallRepository, EFConcertHallRepository>();
            services.AddTransient<IPhotoManager, PhotoManager>();
            services.AddTransient<IConcertRepository, EFConcertRepository>();
            services.AddTransient<IGenreRepository, EFGenreRepository>();
            services.AddTransient<ICommentRepository, EFCommentRepository>();
            services.AddScoped<DataManager>();

            services.AddDefaultIdentity<User>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<AuthenticationStateProvider, ServerAuthenticationStateProvider>();
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
