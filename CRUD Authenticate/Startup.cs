using CRUD_Authenticate.Context;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Authenticate
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    "Server=(localdb)\\FR-L3X9M2J3\\MSSQLSERVER02;Database=customers-db;Trusted_Connection=True;MultipleActiveResultSets=True"));
            services.AddControllersWithViews();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
