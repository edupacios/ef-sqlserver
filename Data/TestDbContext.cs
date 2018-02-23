using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SqlServer.Models;

namespace SqlServer.Data
{
    public class TestDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=TestDB;User Id=sa;Password=;");
        }
    }   
}