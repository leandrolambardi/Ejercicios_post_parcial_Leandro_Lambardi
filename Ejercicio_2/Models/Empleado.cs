using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Models
{
    public abstract class Empleado
    {
        protected int id;
        protected string nombre;
        protected string apellido;
        protected decimal sueldoBase;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal SueldoBase { get => sueldoBase; set => sueldoBase = value; }

        public Empleado(int id, string nombre, string apellido, decimal sueldoBase)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            SueldoBase = sueldoBase;
        }

        public abstract decimal CalcularSueldo();

        public override string ToString()
        {
            return $"{Id} - {Nombre} {Apellido} | Sueldo Final: {CalcularSueldo()}";
        }
    }
}
