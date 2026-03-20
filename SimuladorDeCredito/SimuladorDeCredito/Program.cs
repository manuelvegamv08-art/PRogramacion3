using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1)Entrada solicitte al usuario el monto de prestamo, la tasa de interes mensual (%) y el plazo en meses
//2)calculo: calcule la tuota mensual y desglose cuanto va a capital y cuanto a interes mes a mes 
//3)salida muestra una tabla con #mes,fecha de pago(incrementando un mes a desde hoy con Datetime)
//Abono a Capital, inters y saldo 

namespace SimuladorDeCredito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Monto del préstamo: ");
            double prestamo = double.Parse(Console.ReadLine());

            Console.Write("Tasa de interés mensual: ");
            double tasa = double.Parse(Console.ReadLine());

            if (tasa > 1)
            {
                tasa = tasa / 100;
            }

            Console.Write("Meses: ");
            int meses = int.Parse(Console.ReadLine());

            double saldo = prestamo;

            
            double acumulador = 1;
            for (int i = 0; i < meses; i++)
            {
                acumulador *= (1 + tasa);
            }

            double cuota = (prestamo * tasa * acumulador) / (acumulador - 1);

            double totalInteres = 0;
            double totalPagar = 0;

            DateTime fecha = DateTime.Now;

            Console.WriteLine("\nMes\tFecha\t\tCapital\t\tInterés\t\tCuota\t\tSaldo");

            for (int i = 1; i <= meses; i++)
            {
                double interes = saldo * tasa;
                double capital = cuota - interes;

                saldo -= capital;

                totalInteres += interes;
                totalPagar += cuota;

                fecha = fecha.AddMonths(1);

                Console.WriteLine(i + "\t" +
                    fecha.ToShortDateString() + "\t" +
                    capital.ToString("F2") + "\t\t" +
                    interes.ToString("F2") + "\t\t" +
                    cuota.ToString("F2") + "\t\t" +
                    saldo.ToString("F2"));
            }

            Console.WriteLine("\nResumen:");
            Console.WriteLine("Total a pagar: " + totalPagar.ToString("F2"));
            Console.WriteLine("Total interés: " + totalInteres.ToString("F2"));
        }
    }
}