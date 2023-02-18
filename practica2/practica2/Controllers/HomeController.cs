using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using practica2.Models;

namespace practica2.Controllers
{
    public class HomeController : Controller
    {
      
        public HomeController(ILogger<HomeController> logger)
        {
           
           
        }
<<<<<<< HEAD

        public List<Jugador> Index()
        {
            return Listjugadores;
=======
        
        public string Index()
        {
            return "Hola, gamer ¡Juguemos league of legends!";
>>>>>>> 5e0557414a8d17e4e16aabf1f47a5e8c95dd7a87
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
