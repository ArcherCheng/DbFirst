using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FoodPos.Domain
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext()
        {        
        }

        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // string connString = Helper.AppSettingsHelper.Configuration["ConnectionStrings:DefaultConnection"];
                // optionsBuilder.UseSqlServer(connString);
                ////顯示SQL語法指令
                //optionsBuilder.UseLoggerFactory(MyLoggerFactory); 
            }
        }

        public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter((category, level) =>
                    category == DbLoggerCategory.Database.Command.Name
                    && level == LogLevel.Information)
                .AddConsole();
        }); 
    }
}