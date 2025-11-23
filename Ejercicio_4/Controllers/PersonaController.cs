using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Controllers
{
    public class PersonaController
    {
        private List<Persona> _personas = new();

        public void Agregar(Persona p)
        {
            _personas.Add(p);
        }

        public void Listar()
        {
            Console.WriteLine("=== Listado General de la Institución ===");
            foreach (var p in _personas)
            {
                p.MostrarInfo();
            }
        }

        public void Eliminar(int id)
        {
            var persona = _personas.FirstOrDefault(p => p.Id == id);
            if (persona != null)
            {
                _personas.Remove(persona);
            }
        }
    }
}
