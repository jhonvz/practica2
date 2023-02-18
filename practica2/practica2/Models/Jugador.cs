using System;
using System.Collections.Generic;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace practica2.Models
{
    public class Jugador
    {
        [Name("Nombre")]
        public String nombre { get; set; }
        [Name("Apellido")]
        public String apellido { get; set; }
        [Name("Rol")]
        public String rol { get; set; }
        [Name("KDA")]
        public double kda { get; set; }
        [Name("CS")]
        public float cs { get; set; }
        [Name("Equipo")]
        public String equipo { get; set; }
        public Jugador()
        { }
        public Jugador(String nom, String ap, String Rol, double KDA, float CS, String Equipo)
        {
            this.nombre = nom;
            this.apellido = ap;
            this.rol = Rol;
            this.kda = KDA;
            this.cs = CS;
            this.equipo = Equipo;
        }
    }
}
