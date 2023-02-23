using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath("E:\\Projects\\Pets\\To.Do\\To.Do.WebApp\\WebApp")
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Developer> Developers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Project> Projects { get; set; }
    }
}
