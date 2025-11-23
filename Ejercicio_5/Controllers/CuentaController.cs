using Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Controllers
{
    public class CuentaController
    {
        private List<Cuenta> _cuentas = new();

        public void Registrar(Cuenta cuenta)
        {
            _cuentas.Add(cuenta);
        }

        public void Listar()
        {
            Console.WriteLine("=== Listado de Cuentas Bancarias ===");
            foreach (var c in _cuentas)
            {
                c.MostrarInfo();
            }
        }

        public void Depositar(int numeroCuenta, double monto)
        {
            var cuenta = _cuentas.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            cuenta?.Depositar(monto);
        }

        public void Extraer(int numeroCuenta, double monto)
        {
            var cuenta = _cuentas.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
            {
                bool ok = cuenta.Extraer(monto);
                if (!ok)
                    Console.WriteLine("Extracción denegada por saldo insuficiente.");
            }
        }

        public void ActualizarTodos()
        {
            foreach (var c in _cuentas)
                c.ActualizarSaldo();
        }

        public void Eliminar(int numeroCuenta)
        {
            var cuenta = _cuentas.FirstOrDefault(c => c.NumeroCuenta == numeroCuenta);
            if (cuenta != null)
                _cuentas.Remove(cuenta);
        }
    }
}
