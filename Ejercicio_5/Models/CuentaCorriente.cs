using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Models
{
    public class CuentaCorriente : Cuenta
    {
        public double LimiteDescubierto { get; set; }

        public CuentaCorriente(int numero, string titular, double saldoInicial, double limite)
            : base(numero, titular, saldoInicial)
        {
            LimiteDescubierto = limite;
        }

        public override bool Extraer(double monto)
        {
            if (Saldo + LimiteDescubierto >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public override void ActualizarSaldo()
        {
            // No aplica intereses; podría aplicarse un costo de mantenimiento
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Cuenta Corriente] Nº {NumeroCuenta} - Titular: {Titular} - Saldo: ${Saldo} - Descubierto: ${LimiteDescubierto}");
        }
    }
}
