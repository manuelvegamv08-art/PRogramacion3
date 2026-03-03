using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__poo_2_.CuentaBancaria
{
    class CuentaAhorros : CuentaBancaria

    {
        public CuentaAhorros(decimal saldoInicial) : base(saldoInicial)
        {

        }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a retirar debe ser mayor que cero.");
            }

            if (Saldo - monto < 0)
            {
                Console.WriteLine("Fondos insuficientes para realizar el retiro.");
                return;
            }
            else
            { 
                Saldo -= monto;
                Console.WriteLine($"Retiro realizado. Nuevo saldo: {Saldo:C}");

            }

        }
    }
}
