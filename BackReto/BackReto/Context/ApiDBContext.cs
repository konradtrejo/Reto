using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackReto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BackReto.Context
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;port=3306;user=benjamin;password=1234;database=bdverduleria")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information
                )))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        public DbSet<Verdura> verdura { get; set; }
    }
}

