using System;
using Microsoft.EntityFrameworkCore;
using MvcSample.Data.Entities;

namespace MvcSample
{
    public class SampleDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnecionString = "Host=localhost;Database=sample2;Username=postgres;Password=postgres";
            optionsBuilder.UseNpgsql(ConnecionString);
            optionsBuilder.LogTo(Console.WriteLine);
        }


    }
}