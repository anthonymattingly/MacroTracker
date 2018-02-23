using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MacroTracker.Models
{
    public class FoodsConsumed
    {
        public int? FoodsConsumedId { get; set; }
        public List<Food> FoodsEaten { get; set; }
        public DateTime DateConsumed { get; set; }
    }
}