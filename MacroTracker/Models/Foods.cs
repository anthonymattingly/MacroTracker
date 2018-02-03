using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class Foods
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double FatGrams { get; set; }
        public double CarbGrams { get; set; }
        public double ProteinGrams { get; set; }

        public static implicit operator Foods(List<Foods> v)
        {
            throw new NotImplementedException();
        }
    }
}