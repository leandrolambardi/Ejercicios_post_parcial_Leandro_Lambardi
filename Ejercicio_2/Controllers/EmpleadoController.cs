using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Controllers
{
    public class EmpleadoController
    {
        private List<Empleado> empleados = new List<Empleado>();

        // CREATE
        public void Agregar(Empleado emp)
        {
            empleados.Add(emp);
        }

        // READ
        public void Listar()
        {
            Console.WriteLine("\n--- LISTA DE EMPLEADOS ---");
            foreach (var e in empleados)
                Console.WriteLine(e.ToString());
        }

        // UPDATE
        public bool Modificar(int id, string nuevoNombre, string nuevoApellido,
                              decimal nuevoSueldo)
        {
            var emp = empleados.FirstOrDefault(e => e.Id == id);

            if (emp == null) return false;

            emp.Nombre = nuevoNombre;
            emp.Apellido = nuevoApellido;
            emp.SueldoBase = nuevoSueldo;

            return true;
        }

        // DELETE
        public bool Eliminar(int id)
        {
            var emp = empleados.FirstOrDefault(e => e.Id == id);
            if (emp == null) return false;

            empleados.Remove(emp);
            return true;
        }
    }
}
