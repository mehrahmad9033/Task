using Assignment.Domain.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Infrastructure.DB
{
    public class TaskContext: DbContext
    {
        private readonly IConfiguration _configuration;
        protected TaskContext(DbContextOptions options,IConfiguration config) : base(options)
        {
            _configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            optionsBuilder 
            .UseSqlServer(_configuration.GetConnectionString("DefaultConnection")); 
        }
        DbSet<Investor> Investor { get; set; }
        DbSet<Companies> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
