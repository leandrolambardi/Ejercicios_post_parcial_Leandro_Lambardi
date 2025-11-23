using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_post_parcial_Leandro_Lambardi.Ejercicio_5.Models
{
    public abstract class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }

        public Cuenta(int numero, string titular, double saldoInicial)
        {
            NumeroCuenta = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public virtual void Depositar(double monto)
        {
            Saldo += monto;
        }

        public abstract bool Extraer(double monto);

        public abstract void ActualizarSaldo();

        public abstract void MostrarInfo();
    }
}
