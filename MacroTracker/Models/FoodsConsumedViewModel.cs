using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace MacroTracker.Models
{
    public class FoodsConsumedViewModel
    {
        public List<Food> FoodsConsumed { get; set; }
        public DateTime DateConsumed { get; set; }
    }
}