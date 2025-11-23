using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models
{
    public class Vehiculo
    {
        protected int Id;
        protected string Marca;
        protected string Modelo;
        protected int Anio;

        public Vehiculo(int id, string marca, string modelo, int anio)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        // Getters y Setters
        public int GetId() => Id;
        public void SetId(int id) => Id = id;

        public string GetMarca() => Marca;
        public void SetMarca(string marca) => Marca = marca;

        public string GetModelo() => Modelo;
        public void SetModelo(string modelo) => Modelo = modelo;

        public int GetAnio() => Anio;
        public void SetAnio(int anio) => Anio = anio;

        public virtual void MostrarDatos()
        {
            Console.WriteLine($"ID: {Id}, Marca: {Marca}, Modelo: {Modelo}, Año: {Anio}");
        }
    }
}
