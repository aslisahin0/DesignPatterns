﻿using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ASLIS;initial catalog=DesignPattern2;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
