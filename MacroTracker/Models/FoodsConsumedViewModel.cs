using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class FoodsConsumedViewModel
    {
        public List<Foods> FoodsConsumed { get; set; }
        public DateTime DateConsumed { get; set; }
    }
}