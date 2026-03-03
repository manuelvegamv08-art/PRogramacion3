using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__poo_2_.CuentaBancaria
{
    abstract class CuentaBancaria
    {
        public decimal Saldo { get; protected set; }

        public CuentaBancaria(decimal SaldoInicial)
        {
            Saldo = SaldoInicial;
        }

        public void Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                throw new ArgumentException("El monto a depositar debe ser mayor que cero.");
            }
            Saldo += monto;
            Console.WriteLine($"Depósito realizado. Nuevo saldo: {Saldo:C}");

        }
        public abstract void Retirar(decimal monto);
    }
}
