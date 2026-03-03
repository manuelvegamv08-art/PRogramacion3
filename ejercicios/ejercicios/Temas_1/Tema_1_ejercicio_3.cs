using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Control de Aforo en Eventos:
//Una discoteca tiene un aforo máximo de 50 personas. Crea un programa que pregunte cuántas personas quieren entrar.
//Si hay cupo, dales la bienvenida; si no, indícales cuántas personas deben salir para que ellos puedan entrar.

namespace ejercicios.Ejercicios
{
    internal class Tema_1_ejercicio_3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CONTROL DE AFORO EN EVENTOS ===");
            int aforoMaximo = 50;
            Console.Write("Ingrese el número de personas que quieren entrar: ");
            int personasQuierenEntrar = int.Parse(Console.ReadLine());
            if (personasQuierenEntrar <= aforoMaximo)
            {
                Console.WriteLine("¡Bienvenidos a la discoteca! Disfruten de la fiesta.");
            }
            else
            {
                int personasExcedentes = personasQuierenEntrar - aforoMaximo;
                Console.WriteLine($"Lo siento, el aforo máximo es de {aforoMaximo} personas. Por favor, {personasExcedentes} personas deben salir para que puedan entrar.");
            }
        }
    }
}
