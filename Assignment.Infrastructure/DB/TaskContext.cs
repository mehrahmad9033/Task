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
        public TaskContext( IConfiguration config) 
        {
            _configuration = config;
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder
            .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        DbSet<Investor> Investor { get; set; }
        DbSet<Companies> Companies { get; set; } 
    }
}
