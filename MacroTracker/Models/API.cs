using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MacroTracker.Models
{
    public class API
    {
            [DisplayName("Item No.")]
            public int FoodId { get; set; }

            [JsonProperty(PropertyName = "item_name")]
            public string ItemName { get; set; }

            [JsonProperty(PropertyName = "brand_name")]
            public string BrandName { get; set; }

            [JsonProperty(PropertyName = "nf_total_fat")]
            public double TotalFat { get; set; }

            [JsonProperty(PropertyName = "nf_total_carbohydrate")]
            public double TotalCarbs { get; set; }

            [JsonProperty(PropertyName = "nf_protein")]
            public double TotalProtein { get; set; }

    }
}