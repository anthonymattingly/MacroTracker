using System;
using System.Data.Entity;
using System.Linq;
using MacroTracker.Models;
using System.Collections.Generic;


namespace MacroTracker
{


    public class FoodContext : DbContext
    {

        public FoodContext() : base("name=Food") { }

        public virtual DbSet<Food> Foods { get; set; }

        //Default database name FoodsConsumeds 
        public virtual DbSet<FoodsConsumed> FoodsConsumedDb { get; set; }

    }
 
}