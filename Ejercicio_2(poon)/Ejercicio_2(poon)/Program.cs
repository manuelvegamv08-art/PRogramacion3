using System;
using Ejercicio_2_poon_.Clases;

namespace Ejercicio_2_poon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            // Inicializamos dos cuentas de ejemplo
            CuentaAhorros miAhorro = new CuentaAhorros(1000);
            CuentaCorriente miCorriente = new CuentaCorriente(500);

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== CAJERO AUTOMÁTICO ===");
                Console.WriteLine("1. Gestionar Cuenta de Ahorros (Sin Sobregiro)");
                Console.WriteLine("2. Gestionar Cuenta Corriente (Sobregiro $500)");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MenuOperaciones(miAhorro, "Ahorros");
                        break;
                    case "2":
                        MenuOperaciones(miCorriente, "Corriente");
                        break;
                    case "3":
                        salir = true;
                        Console.WriteLine("Gracias por usar el sistema.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione una tecla...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Método auxiliar para no repetir código de depósito/retiro
        static void MenuOperaciones(CuentaBancaria cuenta, string tipo)
        {
            Console.Clear();
            Console.WriteLine($"--- MENÚ CUENTA {tipo.ToUpper()} ---");
            Console.WriteLine($"Saldo actual: ${cuenta.getSaldo()}");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Volver");
            Console.Write("Seleccione: ");

            string op = Console.ReadLine();

            if (op == "3") return;

            Console.Write("Ingrese el monto: ");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                if (op == "1")
                {
                    cuenta.depositar(monto);
                }
                else if (op == "2")
                {
                    // Usamos polimorfismo o verificamos el tipo de cuenta
                    if (cuenta is CuentaAhorros ahorro)
                        ahorro.RetirarAhorros(monto);
                    else if (cuenta is CuentaCorriente corriente)
                        corriente.RetirarConSobregiro(monto);
                }
            }
            else
            {
                Console.WriteLine("Error: El monto debe ser un número válido.");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
