namespace MacroTracker.Migrations
{
    using MacroTracker.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MacroTracker.FoodContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MacroTracker.FoodContext context)
        {

            context.Foods.AddOrUpdate(
                new Food { FoodId=88, FoodName="TestFoodFromSeed",FatGrams=4,CarbGrams=5,ProteinGrams=8}
                );
               
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
