using DDona.POCCore3.Infra.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.POCCore3.ConsoleApp
{
    public class PocContextFactory : IDesignTimeDbContextFactory<PocContext>
    {
        private static string _connectionString;

        public PocContext CreateDbContext()
        {
            return CreateDbContext(null);
        }

        public PocContext CreateDbContext(string[] args)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                LoadConnectionString();
            }

            var builder = new DbContextOptionsBuilder<PocContext>();
            builder.UseSqlServer(_connectionString);

            return new PocContext(builder.Options);
        }

        private static void LoadConnectionString()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);

            var configuration = builder.Build();

            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}
