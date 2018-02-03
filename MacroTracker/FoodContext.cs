using System;
using System.Data.Entity;
using System.Linq;
using MacroTracker.Models;

namespace MacroTracker
{
    

    public class FoodContext : DbContext
    {

        public FoodContext() : base("name=Food") { }
        
        public virtual DbSet<Food> FoodExamples { get; set; }
       
    }

    
}