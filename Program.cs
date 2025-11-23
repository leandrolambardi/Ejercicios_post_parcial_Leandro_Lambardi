using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Controllers;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_1.Models;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Controllers;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_2.Models;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Controllers;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_3.Models;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Controllers;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_4.Models;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Controllers;
using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Models;

namespace Ejercicios_post_parcial_Leandro_Lambardi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("####### Ejercicios Post Parcial CRUD MVC #######");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("####### Ejercicio 1 #######");
            Console.WriteLine();

            //CONTROLADOR DE VEHÍCULO


            VehiculoController controllerV = new VehiculoController();

                // Agregar vehículos
                controllerV.AgregarVehiculo(new Auto(1, "Toyota", "Corolla", 2020, 4));
                controllerV.AgregarVehiculo(new Moto(2, "Honda", "CB500", 2019, 500));
                controllerV.AgregarVehiculo(new Camion(3, "Mercedes", "Actros", 2021, 15));

                // Mostrar todos
                Console.WriteLine("=== Lista de Vehículos ===");
                controllerV.MostrarVehiculos();

                // Modificar un vehículo
                controllerV.ModificarVehiculo(1, modelo: "Corolla XSE");

                // Mostrar todos nuevamente
                Console.WriteLine("=== Lista de Vehículos Después de Modificación ===");
                controllerV.MostrarVehiculos();

                // Eliminar un vehículo
                controllerV.EliminarVehiculo(2);

                // Mostrar todos nuevamente
                Console.WriteLine("=== Lista de Vehículos Después de Eliminación ===");
                controllerV.MostrarVehiculos();
            
            Console.WriteLine();
            Console.WriteLine("####### Ejercicio 2 #######");
            Console.WriteLine();

            //CONTROLADOR DE EMPLEADO

            var controllerE = new EmpleadoController();

            // CREAR
            controllerE.Agregar(new EmpleadoPermanente(1, "Luis", "Gomez", 300000, 5));
            controllerE.Agregar(new EmpleadoTemporal(2, "Carlos", "Luna", 250000, 12));

            // MOSTRAR
            controllerE.Listar();

            // MODIFICAR
            controllerE.Modificar(2, "Carlos", "Luna", 260000);

            Console.WriteLine("\n--- Después de modificar ---");
            controllerE.Listar();

            // ELIMINAR
            controllerE.Eliminar(1);

            Console.WriteLine("\n--- Después de eliminar ---");
            controllerE.Listar();

            Console.WriteLine();
            Console.WriteLine("####### Ejercicio 3 #######");
            Console.WriteLine();

            var controllerI = new InventarioController();

            var leche = new ProductoAlimenticio(1, "Leche Entera", 1200, new DateTime(2025, 3, 15));
            var tv = new ProductoElectronico(2, "Smart TV 55\"", 450000, 24);

            controllerI.AgregarProducto(leche);
            controllerI.AgregarProducto(tv);

            controllerI.ListarInventario();
            Console.WriteLine();
            Console.WriteLine("####### Ejercicio 4 #######");
            Console.WriteLine();

            var controllerEdu = new PersonaController();

            // AGREGAR
            controllerEdu.Agregar(new Alumno(1, "Marcos", 20, 1502, 8.7));
            controllerEdu.Agregar(new Profesor(2, "Roberto", 45, "Matemática", 520000));

            // LISTAR
            controllerEdu.Listar();

            // ELIMINAR
            controllerEdu.Eliminar(1);

            Console.WriteLine("\n--- Después de eliminar ---");
            controllerEdu.Listar();

            Console.WriteLine();
            Console.WriteLine("####### Ejercicio 5 #######");
            Console.WriteLine();

            var controllerBanco = new CuentaController();

            // REGISTRAR CUENTAS
            controllerBanco.Registrar(new CajaAhorro(1, "Leandro", 150000, 5));
            controllerBanco.Registrar(new CuentaCorriente(2, "Marcos", 50000, 30000));

            // LISTAR
            controllerBanco.Listar();

            // DEPÓSITO
            controllerBanco.Depositar(1, 20000);

            // EXTRACCIÓN
            controllerBanco.Extraer(2, 60000);

            // ACTUALIZAR SALDOS (intereses)
            controllerBanco.ActualizarTodos();

            // LISTAR NUEVAMENTE
            Console.WriteLine("\n--- Después de operaciones ---");
            controllerBanco.Listar();

            // ELIMINAR
            controllerBanco.Eliminar(1);

            Console.WriteLine("\n--- Después de eliminar ---");
            controllerBanco.Listar();

        }
    }
}
