namespace DroneCrush.Migrations
{
    using DroneCrush.DataContext;
    using DroneCrush.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DroneCrush.DataContext.DroneDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations/Database";
        }

        protected override void Seed(DroneDb context)
        {
            context.Drone.Add(new Drone()
            {
                ID = 1,
                FirstMidName = "Drone",
                LastName = "Crush"
            });

            context.SaveChanges();
        }
    }
}
