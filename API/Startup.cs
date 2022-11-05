using BLL.Services.Interfaces;
using BLL.Services.Realization;
using DAL;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Realization;
using DAL.Repositories.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

public class Startup
{
    public Startup(IConfiguration configuration) =>
            Configuration = configuration;

        public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection Services)
    {
        Services.AddDbContext<UnitContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("UnitContext")));

        Services.AddTransient<IConsumerRepository, ConsumerRepository>();
        Services.AddTransient<IUnitRepository, UnitRepository>();
        Services.AddTransient<IEnergyConsumeRepository, EnergyConsumeRepository>();

        Services.AddTransient<IUnitOfWork, UnitOfWork>();

        Services.AddTransient<IConsumerService, ConsumerService>();

        Services.AddControllers();
        Services.AddEndpointsApiExplorer();
        Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "ConsumerCatalog.API",
                Version = "v1"
            });

        });
        Services.AddHttpClient();
        Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint(
                "/swagger/v1/swagger.json",
                "ConsumerCatalog.API v1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseStaticFiles();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}