using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio
{
    public class Camion : Vehiculo
    {
        public string capacidadCarga;

        public Camion() { }
        public Camion(string matricula, string marca, string modelo, string año, string color, string kilometros,
        string precioVenta, string precioAlquiler, bool Activo, string ImagenUno, string ImagenDos,
        string ImagenTres, string capacidadCarga) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres, capacidadCarga)
        {
            this.capacidadCarga=capacidadCarga;
        }

        public string GetCapacidadCarga() => capacidadCarga;
        public void SetCapacidadCarga(string capacidadCarga) => this.capacidadCarga = capacidadCarga;
    }
}