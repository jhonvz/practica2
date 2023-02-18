using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CsvHelper;
using System.IO;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using practica2.Models;


namespace practica2.Controllers
{
    [Route("[controller]")]
    public class EquipoController : Controller
    {
        private readonly ILogger<EquipoController> _logger;
        private readonly Equipo equipos;
        List<Equipo> Listequipos = new List<Equipo>();
        public EquipoController(ILogger<EquipoController> logger)
        {
            _logger = logger;
            equipos = new Equipo();
            Listequipos.Add(new Equipo() { nombre = "DRX", coach = "Kim Jeong-soo", creacion = "2017", liga = "Challenger" });
            Listequipos.Add(new Equipo() { nombre = "T1", coach = "Bae Seong-woong", creacion = "2019", liga = "Challenger" });
            Listequipos.Add(new Equipo() { nombre = "Fnatic", coach = "Gonçalo Pinto Brandão", creacion = "2011", liga = "Challenger" });
            Listequipos.Add(new Equipo() { nombre = "Mad Lions", coach = "James MacCormack", creacion = "2019", liga = "Challenger" });
        }
            public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("manual")]
        public List<Equipo> Getmanual()
        {
            return Listequipos;
        }
    }
}
