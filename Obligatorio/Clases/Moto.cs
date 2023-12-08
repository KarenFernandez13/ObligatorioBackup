using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Moto : Vehiculo
    {
        public string cilindrada;

        public Moto() { }
        public Moto(string matricula, string marca, string modelo, string año, string color, string kilometros,
           string precioVenta, string precioAlquiler, bool Activo, string ImagenUno, string ImagenDos, 
           string ImagenTres, string cilindrada) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres, cilindrada)
        {            
            this.cilindrada = cilindrada;
        }

        public string GetCilindrada() => cilindrada;
        public void SetCilindrada(string cilindrada) => this.cilindrada = cilindrada;

    }
}