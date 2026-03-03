using System;

namespace ejercicios.Ejercicios
{
    internal class Tema_1_ejercicio_1
    {
        static void Ejecutar(string[] args)
        {
            Console.WriteLine("=== PERFIL DE USUARIO GAMER ===");

            Console.Write("Ingrese su Nickname: ");
            string nickname = Console.ReadLine();

            Console.Write("Ingrese su nivel de experiencia (1-100): ");
            int nivel = int.Parse(Console.ReadLine());

            Console.Write("¿Tiene suscripción Premium? (true/false): ");
            bool premium = bool.Parse(Console.ReadLine());

            Console.WriteLine("\n===== BIENVENIDO =====");

            string categoria;

            if (nivel >= 1 && nivel <= 30)
            {
                categoria = "Novato";
            }
            else if (nivel <= 70)
            {
                categoria = "Intermedio";
            }
            else if (nivel <= 100)
            {
                categoria = "Experto";
            }
            else
            {
                categoria = "Nivel inválido";
            }

            Console.WriteLine($"Jugador: {nickname}");
            Console.WriteLine($"Nivel: {nivel} ({categoria})");

            if (premium)
            {
                Console.WriteLine("Estado: Usuario Premium ⭐");
            }
            else
            {
                Console.WriteLine("Estado: Usuario Estándar");
            }

            Console.WriteLine("¡Bienvenido al mundo gamer!");
        }
    }
}