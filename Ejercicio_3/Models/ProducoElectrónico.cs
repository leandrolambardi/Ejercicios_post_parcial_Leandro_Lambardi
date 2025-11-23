using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Models
{
    public class ProductoElectronico : Producto
    {
        public int MesesGarantia { get; set; }

        public ProductoElectronico(int id, string nombre, decimal precioBase, int mesesGarantia)
            : base(id, nombre, precioBase)
        {
            MesesGarantia = mesesGarantia;
        }

        public override string ObtenerDescripcion()
        {
            return $"[Electrónico] {Nombre} - ${PrecioBase} - Garantía: {MesesGarantia} meses";
        }
    }
}
