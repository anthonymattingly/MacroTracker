using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MacroTracker.Controllers
{
    public class APIController : Controller
    {
        public static HttpClient HttpClient;

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            if (HttpClient == null)
                HttpClient = new HttpClient();

            var httpResponseMessage = await HttpClient.GetAsync("https://api.nutritionix.com/v1_1/item?upc=52200004265&appId=e0163b65&appKey=8ed609261705cdd02174f4847b44419b");

            if (true == false) //(!httpResponseMessage.IsSuccessStatusCode)
                throw new Exception("Unable to connect to CoinMarketCap.");

            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();

            var coins = JsonConvert.DeserializeObject<List<Coin>>(responseString);

            var coinListViewModel = new CoinListViewModel
            {
                Coins = coins,
                SecondsToReload = 60
            };

            return View(coinListViewModel);
        }
    }
}