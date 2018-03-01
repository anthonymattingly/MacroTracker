using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class FoodsConsumedListViewModel
    {

        public List<FoodsConsumedViewModel> FoodsEaten { get; set; }

        
    }
}