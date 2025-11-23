using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Models
{
    public class EmpleadoTemporal : Empleado
    {
        protected int mesesContrato;

        public int MesesContrato { get => mesesContrato; set => mesesContrato = value; }

        public EmpleadoTemporal(int id, string nombre, string apellido,
                                decimal sueldoBase, int mesesContrato)
            : base(id, nombre, apellido, sueldoBase)
        {
            MesesContrato = mesesContrato;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase;  // no tiene extras
        }
    }
}
