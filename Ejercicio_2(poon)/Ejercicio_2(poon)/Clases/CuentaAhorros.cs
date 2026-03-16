using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//mplementa CuentaAhorros: No permite sobregiros (el saldo no puede ser negativo).

namespace Ejercicio_2_poon_.Clases
{
    internal class CuentaAhorros : CuentaBancaria
    {
        // Usamos ":" para heredar de CuentaBancaria
        
        
            // El constructor de la hija llama al constructor de la base usando "base"
            public CuentaAhorros(double saldo) : base(saldo, 0)
            {
            }

            // Sobrescribimos o creamos el método de retiro con la validación estricta
            public void RetirarAhorros(double montoARetirar)
            {
                // Accedemos al saldo de la clase base
                double saldoActual = getSaldo();

                if (montoARetirar > saldoActual)
                {
                    Console.WriteLine("--- ERROR DE AHORROS ---");
                    Console.WriteLine($"Intento de retiro: {montoARetirar}");
                    Console.WriteLine($"Saldo disponible: {saldoActual}");
                    Console.WriteLine("Operación denegada: Una Cuenta de Ahorros no permite sobregiros.");
                }
                else
                {
                    // Si es válido, actualizamos el saldo usando el set de la base
                    setSaldo(saldoActual - montoARetirar);
                    Console.WriteLine($"Retiro exitoso. Nuevo saldo de ahorros: {getSaldo()}");
                }
            }
        }
    }



