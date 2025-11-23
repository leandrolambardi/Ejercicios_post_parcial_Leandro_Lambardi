using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models
{
    public class Moto : Vehiculo
    {
        protected int Cilindrada;

        public Moto(int id, string marca, string modelo, int anio, int cilindrada)
            : base(id, marca, modelo, anio)
        {
            Cilindrada = cilindrada;
        }

        public int GetCilindrada() => Cilindrada;
        public void SetCilindrada(int cilindrada) => Cilindrada = cilindrada;

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Cilindrada: {Cilindrada} cc");
        }
    }

}
