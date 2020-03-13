using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AlphaTeamTippSpiel.Controllers
{
    public class StatsController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return this.View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name)
        {
            this.ViewData["Nachricht"] = "Hallo " + name + ",\nWillkommen auf deiner persönlichen Statistiken-Seite!";
            
            return this.View();
        }
    }
}