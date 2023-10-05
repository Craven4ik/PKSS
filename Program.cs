using Microsoft.EntityFrameworkCore;
using PKSS.Database;
using PKSS.Models;
using PKSS.Repositories.Implimentations;
using PKSS.Repositories.Interfaces;
using PKSS.Services.Implimentations;
using PKSS.Services.Interfaces;

namespace PKSS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DB");
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString));

            builder.Services.AddTransient<IRepairService, RepairService>();
            builder.Services.AddTransient<IBaseRepository<Document>, BaseRepository<Document>>();
            builder.Services.AddTransient<IBaseRepository<Car>, BaseRepository<Car>>();
            builder.Services.AddTransient<IBaseRepository<Worker>, BaseRepository<Worker>>();

        // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}