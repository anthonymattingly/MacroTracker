using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class FoodsViewModel
    {
        public int? FoodId { get; set; }

        [DisplayName("Name of Food")]
        public string FoodName { get; set; }

        [DisplayName("Grams of Fat")]
        public double FatGrams { get; set; }

        [DisplayName("Grams of Carbs")]
        public double CarbGrams { get; set; }

        [DisplayName("Grams of Protein")]
        public double ProteinGrams { get; set; }
    }
}