using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MacroTracker.Models
{
    public class FoodsConsumed
    {

        public int FoodsConsumedId { get; set; }

        [StringLength(50)]
        public string ConsumedFoodName { get; set; }

        [Range(0, 9999)]
        public double ConsumedFatGrams { get; set; }

        [Range(0, 9999)]
        public double ConsumedCarbGrams { get; set; }

        [Range(0, 9999)]
        public double ConsumedProteinGrams { get; set; }

        public DateTime DateConsumed { get; set; }

    }
}