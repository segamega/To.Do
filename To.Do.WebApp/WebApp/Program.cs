using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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