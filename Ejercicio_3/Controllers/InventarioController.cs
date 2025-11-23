using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Controllers
{
    public class InventarioController
    {
        private List<Producto> _inventario = new();

        public void AgregarProducto(Producto p)
        {
            _inventario.Add(p);
        }

        public void ListarInventario()
        {
            Console.WriteLine("===== INVENTARIO COMPLETO =====");

            foreach (var p in _inventario)
            {
                Console.WriteLine(p.ObtenerDescripcion());
            }

            Console.WriteLine("================================\n");
        }
    }
}
