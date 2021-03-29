using EntityLayer.AdminRepository;
using EntityLayer.Authentication.Common;
using EntityLayer.Authentication.IService;
using EntityLayer.Authentication.Service;
using EntityLayer.DataAccess;
using EntityLayer.IAdminRepositorys;
using EntityLayer.SavingsRepository;
using EntityLayer.SavingsRepository.ISavingsRepositorys;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AdyMfb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        //ioc container(inversion of control)
        public void ConfigureServices(IServiceCollection services)
        {
            //Configure Services for CORS

            services.AddCors(options => options.AddPolicy("AllowEverthing", builder => builder.AllowAnyOrigin()
            .AllowAnyMethod().AllowAnyHeader()));

            services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling
            = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IMailService, MailService>();

            //Add service for Junaid Personal Database connection
            //services.AddDbContext<ApplicationDbContext>(options =>
           // options.UseSqlServer(Configuration.GetConnectionString("JunaidConnection")));

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ISavingsRepository, SavingsRepositoryImplementation>();
            services.AddScoped<IAdminRepository, AdminRepositoryImplementation>();

            //Global.ConnectionString = Configuration.GetConnectionString("JunaidConnection");
            Global.ConnectionString = Configuration.GetConnectionString("DefaultConnection");

            Global.DomainName = Configuration["DomainName"];

            services.AddSwaggerGen(c =>
          {
              c.SwaggerDoc("v1", new OpenApiInfo { Title = "AdyMfb", Version = "v1" });
          });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Inject CORS into a container
            //app.UseCors(options => options.AllowAnyOrigin());
            app.UseCors("AllowEverthing");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AdyMfb v1"));
            }

            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}