using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using my_school.MVVM.Model.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_school.Data
{
    internal class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(
       DbContextOptionsBuilder optionsBuilder)
        {

            string filePath =
                "C:\\Users\\user\\source\\repos\\my-school\\appsettings.json";

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(filePath)
                    .Build();
                var connectionString =
                    configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<User> Users { get; set; }
    }
}
