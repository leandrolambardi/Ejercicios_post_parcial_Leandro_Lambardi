using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models
{
    public class Camion : Vehiculo
    {
        protected double CapacidadCarga;

        public Camion(int id, string marca, string modelo, int anio, double capacidad)
            : base(id, marca, modelo, anio)
        {
            CapacidadCarga = capacidad;
        }

        public double GetCapacidadCarga() => CapacidadCarga;
        public void SetCapacidadCarga(double capacidad) => CapacidadCarga = capacidad;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Capacidad de carga: {CapacidadCarga} toneladas");
        }
    }
}
