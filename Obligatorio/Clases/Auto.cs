using Antlr.Runtime.Misc;
using Obligatorio.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;

namespace Obligatorio
{
    public class Auto : Vehiculo
    {
        public string numeroPasajeros;
        public Auto() : base() { }

        public Auto(string matricula, string marca, string modelo, string año, string color, string kilometros,
        string precioVenta, string precioAlquiler, bool Activo, string ImagenUno, string ImagenDos,
        string ImagenTres, string numeroPasajeros) : base(matricula, marca, modelo, año,
               color, kilometros, precioVenta, precioAlquiler, Activo, ImagenUno, ImagenDos, ImagenTres, numeroPasajeros)
        {
            this.numeroPasajeros = numeroPasajeros;
        }


        public string GetNumeroPasajeros() => numeroPasajeros;
        public void SetNumeroPasajeros(string numeroPasajeros) => this.numeroPasajeros = numeroPasajeros;
    }

}