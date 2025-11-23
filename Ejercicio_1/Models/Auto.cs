using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models
{
    public class Auto : Vehiculo
    {
        protected int CantidadPuertas;

        public Auto (int id, string marca, string modelo, int anio, int puertas)
            : base(id, marca, modelo, anio)
        {
            CantidadPuertas = puertas;
        }

        public int GetCantidadPuertas() => CantidadPuertas;
        public void SetCantidadPuertas(int puertas) => CantidadPuertas = puertas;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Cantidad de puertas: {CantidadPuertas}");
        }
    }

}
