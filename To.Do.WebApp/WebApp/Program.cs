using DataAccess.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApp.Bootstrap;

namespace WebApp
{
    /// <summary>
    /// ����� Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// ����� �����.
        /// </summary>
        /// <param name="args">��������� ��������� ������.</param>
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.UseServices();

            // �������� ������ ����������� �� ����� ������������
            var connection = builder.Configuration["ConnectionStrings:DefaultConnection"];
            //string connection = builder.Configuration.GetConnectionString("DefaultConnection");

            // ��������� �������� ApplicationContext � �������� ������� � ����������
            builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection,
                b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));

            var app = builder.Build();

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