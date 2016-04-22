using DroneCrush.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DroneCrush.DataContext
{
    public class DroneDb : DbContext
    {

        public DroneDb() : base("DefaultConnection")
        {
           
        }

        public DbSet<Drone> Drone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("library");

            base.OnModelCreating(modelBuilder);
        }
    
    }

}