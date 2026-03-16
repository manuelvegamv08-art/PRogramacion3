using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo_2_C_.Modelo
{
    public class Veiculo
    {
        public int id;
        public String marca;
        public String modelo;
        public int año;
        public Enum.TipoCombustible tipoCombustible;
        public Enum.EstadoVehiculo estado;

        public Veiculo(int id, string marca, string modelo, int año, Enum.TipoCombustible tipoCombustible, Enum.EstadoVehiculo estado)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.tipoCombustible = tipoCombustible;
            this.estado = estado;
        }

        //private static Veiculo[] inventario = new Veiculo[10];
        //private static int contador = 0;

        //public static void AgregarVehiculo(Veiculo nuevoVehiculo)
        //{
        //    if (contador < inventario.Length)
        //    {
        //        inventario[contador] = nuevoVehiculo;
        //        contador++;
        //        Console.WriteLine("Vehículo guardado en el array.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error: Array lleno.");
        //    }
        //}

        //public static void MostrarCantidad()
        //{
        //    Console.WriteLine($"Hay {contador} vehículos registrados actualmente.");
        //}

    }

}
