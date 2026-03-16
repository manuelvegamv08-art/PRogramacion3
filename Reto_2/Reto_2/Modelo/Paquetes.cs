using Reto_2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
            Guia = guia;
            Destinatario = destinatario;
            Peso = peso;
            Tipo = tipo;
        }
    }
}