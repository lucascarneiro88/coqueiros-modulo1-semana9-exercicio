
using exercicio_semana9.Models;
using Microsoft.EntityFrameworkCore;

namespace exercicio_semana9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            string connectionString = "Server=DESKTOP-DA6EN1S\\SQLEXPRESS;Database=Semana;Trusted_Connection=True;TrustServerCertificate=True;";
            builder.Services.AddDbContext<SemanaContext>(o => o.UseSqlServer(connectionString));



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