using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using KellyDeliWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace KellyDeliWebApp.Controllers
{
    public class ShopsController : Controller
    {
        public IActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\johnp\source\repos\KellyDeliWebApp\KellyDeliWebApp\AppData\shops.json");
           

            var shops = JsonConvert.DeserializeObject<Shops>(json);

            if (json == null) { return View("Error"); }

            
            return View(shops);
        }
    }
}
