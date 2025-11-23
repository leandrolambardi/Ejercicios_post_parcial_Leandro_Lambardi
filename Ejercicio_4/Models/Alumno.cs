using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Models
{
    public class Alumno : Persona
    {
        public int Legajo { get; set; }
        public double Promedio { get; set; }

        public Alumno(int id, string nombre, int edad, int legajo, double promedio)
            : base(id, nombre, edad)
        {
            Legajo = legajo;
            Promedio = promedio;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Alumno] Id:{Id} - {Nombre}, Edad:{Edad}, Legajo:{Legajo}, Prom:{Promedio}");
        }
    }
}
