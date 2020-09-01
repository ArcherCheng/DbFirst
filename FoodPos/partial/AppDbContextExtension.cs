using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DbFirst.FoodPos.Data
{
    public partial class AppDbContext : DbContext
    {
        //// static LoggerFactory object;
        // public static readonly ILoggerFactory MyLoggerFactory
        // = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static readonly ILoggerFactory MyLoggerFactory
        = LoggerFactory.Create(builder =>
        {
            builder
                .AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)
                .AddConsole();
        }); 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseLoggerFactory(MyLoggerFactory) 
                .UseSqlServer("server=(local)\\SqlExpress;database=foodPos2;Trusted_Connection=True;");
            }            
        }

    }


}