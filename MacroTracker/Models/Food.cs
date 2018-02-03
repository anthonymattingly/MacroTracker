using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MacroTracker.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double FatGrams { get; set; }
        public double CarbGrams { get; set; }
        public double ProteinGrams { get; set; }
        public List<Food> FoodList { get; set; }



    }
}