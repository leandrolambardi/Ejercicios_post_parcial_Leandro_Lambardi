using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Models
{
    public class CajaAhorro : Cuenta
    {
        public double TasaInteres { get; set; }

        public CajaAhorro(int numero, string titular, double saldoInicial, double tasa)
            : base(numero, titular, saldoInicial)
        {
            TasaInteres = tasa;
        }

        public override bool Extraer(double monto)
        {
            if (Saldo >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public override void ActualizarSaldo()
        {
            Saldo += Saldo * (TasaInteres / 100);
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"[Caja de Ahorro] Nº {NumeroCuenta} - Titular: {Titular} - Saldo: ${Saldo} - Interés: {TasaInteres}%");
        }
    }
}
