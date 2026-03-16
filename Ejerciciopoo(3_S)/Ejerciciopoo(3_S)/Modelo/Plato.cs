using System;
using Ejerciciopoo_3_S_.Enus;

namespace Ejerciciopoo_3_S_.Modelo
{
    public abstract class Plato
    {
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public int TiempoPreparacion { get; set; }

        public TipodeComida Tipo { get; set; }
        public NivelDificultad Dificultad { get; set; }
        public EstadoOrden Estado { get; set; }

        public Plato(string nombre, double costo, int tiempoPreparacion)
        {
            this.Nombre = nombre;
            this.Costo = costo;
            this.TiempoPreparacion = tiempoPreparacion;
            this.Estado = EstadoOrden.Pendiente;
        }

        public abstract void Preparar();
    }
}