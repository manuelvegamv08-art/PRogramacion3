using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios__poo_2_.CuentaBancaria
{
    class CuentaCorriente : CuentaBancaria
    {
        private const decimal LIMITE_SOBREGIRO = -500;

        public CuentaCorriente(decimal saldoInicial) : base(saldoInicial) { }

        public override void Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("Monto inválido.");
                return;
            }

            if (Saldo - monto < LIMITE_SOBREGIRO)
            {
                Console.WriteLine("Se excede el límite de sobregiro.");
            }
            else
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: {Saldo:C}");
            }
        }
    }
}