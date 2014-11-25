﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Models
{
    public class TravelContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Destination>()
                .Property(d => d.Name).IsRequired();
                modelBuilder.Entity<Destination>()
                .Property(d => d.Description).HasMaxLength(500);
                modelBuilder.Entity<Destination>()
                .Property(d => d.Photo).HasColumnType("image");
                modelBuilder.Entity<Lodging>()
                .Property(l => l.Name).IsRequired().HasMaxLength(200);
            }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<InternetSpecial> InternetSpecials { get; set; }
    }
}
