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
            context.FoodExamples.AddOrUpdate(
                f => f.FoodId,
                new Food { FoodId = 1, FoodName = "Avocado", FatGrams = 30.1, ProteinGrams = 3.3, CarbGrams = 4 },
                new Food { FoodId = 2, FoodName = "Greek Yogurt", FatGrams = 0, ProteinGrams = 25, CarbGrams = 5 },
                new Food { FoodId = 3, FoodName = "Small Chicken Breast", FatGrams = 0.8, ProteinGrams = 22.5, CarbGrams = 4.1 },
                new Food { FoodId = 4, FoodName = "Banana", FatGrams = 2, ProteinGrams = 1.2, CarbGrams = 35.2 },
                new Food { FoodId = 5, FoodName = "Pirate Booty", FatGrams = 0, ProteinGrams = 1.1, CarbGrams = 7}
             );
        }
    }
}
