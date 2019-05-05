using ApiTutorial.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTutorial
{
    public class dbContextApi : DbContext
    {
        //CLASSES
        public DbSet<User> User { get; set; }

        public dbContextApi(DbContextOptions<dbContextApi> options) : base(options) { }
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<dbContextApi>
        {
            public dbContextApi CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var builder = new DbContextOptionsBuilder<dbContextApi>();
                var connectionString = configuration.GetConnectionString("DefaultConecction");
                builder.UseSqlServer(connectionString);
                return new dbContextApi(builder.Options);
            }
        }
    }
}
