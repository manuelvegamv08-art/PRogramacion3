using EjercicioPoo_2_C_.Modelo;
using EjercicioPoo_2_C_.Enum;
using System;

//Desarrollar un sistema para un concesionario que vende Autos,
//Motocicletas y Camiones. Cada vehículo tiene características comunes pero precios y comisiones diferentes.

namespace EjercicioPoo_2_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(
                1,
                "Toyota",
                "Corolla",
                2022,
                TipoCombustible.Gasolina,
                EstadoVehiculo.Nuevo,
                80000,
                4,
                true,
                true
            );

            Camion camion1 = new Camion(
                2,
                "Volvo",
                "FH",
                2020,
                TipoCombustible.Diesel,
                EstadoVehiculo.Usado,
                150000,
                10000,
                true
            );

            Motosicleta moto1 = new Motosicleta(
                3,
                "Yamaha",
                "R3",
                2021,
                TipoCombustible.Gasolina,
                EstadoVehiculo.Nuevo,
                25000,
                false
            );

            Console.WriteLine("=== AUTO ===");
            Console.WriteLine("Marca: " + auto1.marca);
            Console.WriteLine("Modelo: " + auto1.modelo);
            Console.WriteLine("Precio: " + auto1.precio);
            Console.WriteLine();

            Console.WriteLine("=== CAMION ===");
            Console.WriteLine("Marca: " + camion1.marca);
            Console.WriteLine("Modelo: " + camion1.modelo);
            Console.WriteLine("Capacidad de carga: " + camion1.capacidadCarga);
            Console.WriteLine();

            Console.WriteLine("=== MOTOCICLETA ===");
            Console.WriteLine("Marca: " + moto1.marca);
            Console.WriteLine("Modelo: " + moto1.modelo);
            Console.WriteLine("Precio: " + moto1.precio);

            Console.ReadKey();
        }
    }
}