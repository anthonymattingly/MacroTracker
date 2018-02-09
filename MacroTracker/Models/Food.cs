using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MacroTracker.Models
{
    public class Food
    {
        public int FoodId { get; set; }

        [DisplayName("Food Name")]
        public string FoodName { get; set; }

        [DisplayName("Grams of Fat")]
        public double FatGrams { get; set; }

        [DisplayName("Grams of Carbs")]
        public double CarbGrams { get; set; }

        [DisplayName("Grams of Protein")]
        public double ProteinGrams { get; set; }

    }
}