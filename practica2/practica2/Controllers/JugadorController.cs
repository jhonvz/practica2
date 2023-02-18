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
    [Route("[controller]")]
    public class JugadorController : Controller
    {
        private readonly ILogger<JugadorController> _logger;
        private readonly Jugador jugadores;
        List<Jugador> Listjugadores = new List<Jugador>();
        public JugadorController(ILogger<JugadorController> logger)
        {
            _logger = logger;
          
            jugadores = new Jugador();
            //Equipo de DRX
            Listjugadores.Add(new Jugador() { nombre = "Kim Hyuk", apellido = "Kyu", equipo = "DRX", rol = "ADC", kda = 7.60, cs = 205, });
            Listjugadores.Add(new Jugador() { nombre = "César", apellido = "Bocel", equipo = "DRX", rol = "Jungla", kda = 7.90, cs = 98 });
            Listjugadores.Add(new Jugador() { nombre = "Rodrigo ", apellido = "Castellanos", equipo = "DRX", rol = "SUP", kda = 4.50, cs = 21 });
            Listjugadores.Add(new Jugador() { nombre = "Yoo Su", apellido = "Hyeok", equipo = "DRX", rol = "MID", kda = 4.00, cs = 97 });
            Listjugadores.Add(new Jugador() { nombre = "Hibary", apellido = "Kyoya", equipo = "DRX", rol = "TOP", kda = 6.70, cs = 77 });
            //Euipo T1
            Listjugadores.Add(new Jugador() { nombre = "Pablo", apellido = "Ortiz", equipo = "T1", rol = "ADC", kda = 6.40, cs = 205 });
            Listjugadores.Add(new Jugador() { nombre = "Samuel", apellido = "Deluke", equipo = "T1", rol = "Jungla", kda = 4.60, cs = 104 });
            Listjugadores.Add(new Jugador() { nombre = "Keria ", apellido = "Ryu", equipo = "T1", rol = "SUP", kda = 6.90, cs = 21 });
            Listjugadores.Add(new Jugador() { nombre = "Lee", apellido = "Sang", equipo = "T1", rol = "MID", kda = 7.50, cs = 113 });
            Listjugadores.Add(new Jugador() { nombre = "Sebastian", apellido = "Velazques", equipo = "T1", rol = "TOP", kda = 6.80, cs = 75 });
            //Equipo Fnatic
            Listjugadores.Add(new Jugador() { nombre = "Jhon", apellido = "Wun", equipo = "Fnatic", rol = "ADC", kda = 5.40, cs = 190 });
            Listjugadores.Add(new Jugador() { nombre = "Tao", apellido = "Martinez", equipo = "Fnatic", rol = "Jungla", kda = 7.60, cs = 112 });
            Listjugadores.Add(new Jugador() { nombre = "Rosa ", apellido = "Paredez", equipo = "Fnatic", rol = "SUP", kda = 9.20, cs = 29 });
            Listjugadores.Add(new Jugador() { nombre = "Alejandro", apellido = "Melano", equipo = "Fnatic", rol = "MID", kda = 7.30, cs = 123 });
            Listjugadores.Add(new Jugador() { nombre = "Armando", apellido = "Segura", equipo = "Fnatic", rol = "TOP", kda = 8.40, cs = 79 });
            //Equipo Mad Lions
            Listjugadores.Add(new Jugador() { nombre = "Carlos", apellido = "Solarez", equipo = "Mad lions", rol = "ADC", kda = 9.40, cs = 170 });
            Listjugadores.Add(new Jugador() { nombre = "Arturo", apellido = "Ventura", equipo = "Mad lions", rol = "Jungla", kda = 6.50, cs = 122 });
            Listjugadores.Add(new Jugador() { nombre = "Genji ", apellido = "Shimada", equipo = "Mad lions", rol = "SUP", kda = 6.20, cs = 31 });
            Listjugadores.Add(new Jugador() { nombre = "Yasuo", apellido = "Ramirez", equipo = "Mad lions", rol = "MID", kda = 8.30, cs = 135 });
            Listjugadores.Add(new Jugador() { nombre = "Ashe", apellido = "Cifuentes", equipo = "Mad lions", rol = "TOP", kda = 8.00, cs = 80 });


        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("manual")]
        public List<Jugador> Getmanual()
        {
            return Listjugadores;
        }
    }
}
