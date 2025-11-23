using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Controllers
{
    public class VehiculoController
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        // CREATE
        public void AgregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
            Console.WriteLine("Vehículo agregado correctamente.");
        }

        // READ
        public void MostrarVehiculos()
        {
            if (vehiculos.Count == 0)
            {
                Console.WriteLine("No hay vehículos en el sistema.");
                return;
            }

            foreach (var v in vehiculos)
            {
                v.MostrarDatos();
                Console.WriteLine("-------------------------");
            }
        }

        // UPDATE
        public void ModificarVehiculo(int id, string marca = null, string modelo = null, int? anio = null)
        {
            var v = vehiculos.FirstOrDefault(x => x.GetId() == id);
            if (v == null)
            {
                Console.WriteLine("Vehículo no encontrado.");
                return;
            }

            if (marca != null) v.SetMarca(marca);
            if (modelo != null) v.SetModelo(modelo);
            if (anio.HasValue) v.SetAnio(anio.Value);

            Console.WriteLine("Vehículo modificado correctamente.");
        }

        // DELETE
        public void EliminarVehiculo(int id)
        {
            var v = vehiculos.FirstOrDefault(x => x.GetId() == id);
            if (v != null)
            {
                vehiculos.Remove(v);
                Console.WriteLine("Vehículo eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
    }
}
