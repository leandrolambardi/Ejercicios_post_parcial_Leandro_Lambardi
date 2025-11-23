using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Models
{
    public class EmpleadoPermanente : Empleado
    {
        protected int antiguedad; // en años

        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public EmpleadoPermanente(int id, string nombre, string apellido,
                                  decimal sueldoBase, int antiguedad)
            : base(id, nombre, apellido, sueldoBase)
        {
            Antiguedad = antiguedad;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + (Antiguedad * 10000);
        }
    }
}
