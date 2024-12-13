using CarSale.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarSale.DAL.Context
{
    public class CarSalesDB : DbContext
    {
        public CarSalesDB(DbContextOptions<CarSalesDB> options) : base(options)
        {
                
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Configuration> Configurations { get; set; }
    }
}
