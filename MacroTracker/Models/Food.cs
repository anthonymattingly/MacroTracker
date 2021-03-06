﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MacroTracker.Models
{
    public class Food
    {
        
        public int FoodId { get; set; }

        [StringLength(50)]
        public string FoodName { get; set; }

        public double FatGrams { get; set; }

        public double CarbGrams { get; set; }
        
        public double ProteinGrams { get; set; }

    }
}