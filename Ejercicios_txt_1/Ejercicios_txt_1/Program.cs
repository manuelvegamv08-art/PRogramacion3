using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_txt_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los ejercicios de texto. Por favor, selecciona un ejercicio:");
            Console.WriteLine("1. Diario Personal con Bitácora (Clase File y DateTime)");
            int opcion = int.Parse(Console.ReadLine());

            try { }catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
           
        }
    }
}
