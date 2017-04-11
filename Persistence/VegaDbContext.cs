﻿using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Persitence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; } 
        
        public DbSet<Feature> Features { get; set; }    
    }
}
