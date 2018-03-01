using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class FoodsConsumedViewModel
    {
        public int? FoodsConsumedId { get; set; }

        //public List<Food> FoodsEaten { get; set; }

        [DisplayName("Food Name")]
        [StringLength(50)]
        public string ConsumedFoodName { get; set; }

        [DisplayName("Grams of Fat")]
        [Range(0, 9999)]
        public double ConsumedFatGrams { get; set; }

        [DisplayName("Grams of Carbs")]
        [Range(0, 9999)]
        public double ConsumedCarbGrams { get; set; }

        [DisplayName("Grams of Protein")]
        [Range(0, 9999)]
        public double ConsumedProteinGrams { get; set; }

        public DateTime DateConsumed { get; set; }
    }
}