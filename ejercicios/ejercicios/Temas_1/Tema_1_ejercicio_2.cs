using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Calculadora de Propina Solidaria: Pide el total de una cuenta en un restaurante.
//Pregunta qué porcentaje de propina desea
//dejar (10%, 15% o 20%). Si el total con propina supera los $100.000, muestra un 
//mensaje agradeciendo 
//su generosidad.

namespace ejercicios.Ejercicios
{

    internal class Tema_1_ejercicio_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE PROPINA SOLIDARIA ===");
            int totalCuenta;
            Console.Write("Ingrese el total de la cuenta: ");
            
            totalCuenta = int.Parse(Console.ReadLine());
            Console.Write("¿Qué porcentaje de propina desea dejar (10, 15 o 20)? ");

            int porcentajePropina;
            porcentajePropina = int.Parse(Console.ReadLine());

            if (porcentajePropina != 10 && porcentajePropina != 15 && porcentajePropina != 20)
            {
                Console.WriteLine("Porcentaje inválido.");
                return;
            }

            double propina = totalCuenta * porcentajePropina / 100.0;
            double totalConPropina = totalCuenta + propina;

            

            if  (totalConPropina > 100000)
            {
                Console.WriteLine("¡Gracias por su generosidad! Su propina solidaria ayudará a quienes lo necesitan.");
            }
            else
            {
                Console.WriteLine($"El total con propina es: {totalConPropina:C}");
            }

        }
    
     
}
