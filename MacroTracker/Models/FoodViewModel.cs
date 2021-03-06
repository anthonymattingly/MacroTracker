﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class FoodViewModel
    {
        [DisplayName("Item No.")]
        public int? FoodId { get; set; }

        [DisplayName("Food Name")]
        [StringLength(50)]
        public string FoodName { get; set; }

        [DisplayName("Grams of Fat")]
        [Range(0, 9999)]
        public double FatGrams { get; set; }

        [DisplayName("Grams of Carbs")]
        [Range(0, 9999)]
        public double CarbGrams { get; set; }

        [DisplayName("Grams of Protein")]
        [Range(0, 9999)]
        public double ProteinGrams { get; set; }

    }
}