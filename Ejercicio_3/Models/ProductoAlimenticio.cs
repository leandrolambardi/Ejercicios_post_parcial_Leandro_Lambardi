using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Models
{
    public class ProductoAlimenticio : Producto
    {
        public DateTime FechaVencimiento { get; set; }

        public ProductoAlimenticio(int id, string nombre, decimal precioBase, DateTime fechaVencimiento)
            : base(id, nombre, precioBase)
        {
            FechaVencimiento = fechaVencimiento;
        }

        public override string ObtenerDescripcion()
        {
            return $"[Alimenticio] {Nombre} - ${PrecioBase} - Vence: {FechaVencimiento:dd/MM/yyyy}";
        }
    }
}
