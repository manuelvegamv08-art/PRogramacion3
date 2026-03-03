using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Simulador de Semáforo Inteligente: Pide al usuario que ingrese el color actual del semáforo (Verde, Amarillo, Rojo).
//Si es verde, imprime "Sigue adelante"; si es amarillo, "Prepárate para frenar"; y si es rojo, "¡Detente!".

namespace ejercicios.Ejercicios
{
    internal class Tema_1_ejercicio_5
    {
        public void Main()
        {
            Console.WriteLine("=== SIMULADOR DE SEMÁFORO INTELIGENTE ===");
            Console.Write("Ingrese el color actual del semáforo (Verde, Amarillo, Rojo): ");
            string colorSemaforo = Console.ReadLine().ToLower();
            switch (colorSemaforo)
            {
                case "verde":
                    Console.WriteLine("Sigue adelante");
                    break;
                case "amarillo":
                    Console.WriteLine("Prepárate para frenar");
                    break;
                case "rojo":
                    Console.WriteLine("¡Detente!");
                    break;
                default:
                    Console.WriteLine("Color de semáforo inválido. Por favor ingrese Verde, Amarillo o Rojo.");
                    break;
            }
        }
    }
}
