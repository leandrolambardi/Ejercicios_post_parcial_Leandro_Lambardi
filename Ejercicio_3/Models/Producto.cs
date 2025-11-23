using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Models
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }

        public Producto(int id, string nombre, decimal precioBase)
        {
            Id = id;
            Nombre = nombre;
            PrecioBase = precioBase;
        }

        public abstract string ObtenerDescripcion();
    }
}
