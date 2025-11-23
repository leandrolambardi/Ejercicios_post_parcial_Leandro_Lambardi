using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Models
{
    public class Profesor : Persona
    {
        public string Materia { get; set; }
        public double Sueldo { get; set; }

        public Profesor(int id, string nombre, int edad, string materia, double sueldo)
            : base(id, nombre, edad)
        {
            Materia = materia;
            Sueldo = sueldo;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Profesor] Id:{Id} - {Nombre}, Edad:{Edad}, Materia:{Materia}, Sueldo:${Sueldo}");
        }
    }

}
