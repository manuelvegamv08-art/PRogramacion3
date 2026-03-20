
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Program.csv


namespace Reto_2.Modelo
{
    public enum TipoEnvio
    {
        Nacional = 0,
        Internacional = 1
    }

    public class Paquetes
    {
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public double Peso { get; set; }
        public TipoEnvio Tipo { get; set; }

        public Paquetes(int guia, string destinatario, double peso, TipoEnvio tipo)
        {
            this.Guia = guia;
            this.Destinatario = destinatario;
            this.Peso = peso;
            this.Tipo = tipo;
        }

        public double CalcularCosto()
        {
            double costoBase = 0;
            if (Tipo == TipoEnvio.Nacional)
            {
                costoBase = 5.0; // Costo base para envíos nacionales
            }
            else if (Tipo == TipoEnvio.Internacional)
            {
                costoBase = 10.0; // Costo base para envíos internacionales
            }
            // Costo adicional por peso
            double costoAdicional = Peso * 0.5; // Costo adicional por kilogramo
            return costoBase + costoAdicional;
        }

        public override string ToString()
        {
            return $"Guía: {Guia}, Destinatario: {Destinatario}, Peso: {Peso} kg, Tipo: {Tipo}, Costo: {CalcularCosto():C}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Paquetes paquete)
            {
                return this.Guia == paquete.Guia;
            }
            return false;
        }

       
    }


}