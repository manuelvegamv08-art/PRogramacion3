using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gestión de Inventario de Tienda: Define una clase Producto con nombre, precio y stock.
//Crea un método que permita "vender" el producto, 
//restando del stock y mostrando el total de la venta. Si no hay stock, debe avisar al usuario.

namespace ConsoleApp1.Ejercicios
{

   
        class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }

            public Producto(string nombre, double precio, int stock)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }

            public void Vender(int cantidad)
            {
                if (Stock <= 0)
                {
                    Console.WriteLine("No hay stock disponible de " + Nombre);
                    return;
                }

                if (cantidad > Stock)
                {
                    Console.WriteLine("Stock insuficiente. Solo quedan " + Stock + " unidades.");
                    return;
                }

                Stock -= cantidad;
                double total = cantidad * Precio;

                Console.WriteLine("Venta realizada de " + cantidad + " unidad(es) de " + Nombre);
                Console.WriteLine("Total a pagar: $" + total);
                Console.WriteLine("Stock restante: " + Stock);
            }
        }

        
    }

