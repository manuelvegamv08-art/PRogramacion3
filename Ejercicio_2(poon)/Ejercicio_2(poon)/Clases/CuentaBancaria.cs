using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_poon_.Clases
{
    internal class CuentaBancaria
    {
        double saldo;
        double retiro;

        public CuentaBancaria(double saldo, double retiro)
        {
            this.saldo = saldo;
            this.retiro = retiro;
        }
        public double getSaldo() {
            return saldo;
        }
        public double getRetiro() {
            return retiro;
        }
         public void setSaldo(double saldo) {
            this.saldo = saldo;
        }
         public void setRetiro(double retiro) {
            this.retiro = retiro;
        }
        public void retirar() {
            if (retiro > saldo) {
                Console.WriteLine("No se puede realizar el retiro, saldo insuficiente.");
            } else {
                saldo -= retiro;
                Console.WriteLine("Retiro realizado con éxito. Saldo actual: " + saldo);
            }
        }

        public void depositar(double monto) 
        {
            if (monto > 0)
            {
            this.saldo += monto;
                Console.WriteLine("Depósito realizado con éxito. Saldo actual: " + monto);
                Console.WriteLine($"Nuevo saldo total: ${this.saldo}");
            } else {
                Console.WriteLine("El monto a depositar debe ser positivo.");

            }

        }

    }
}
