using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Obligatorio.Clases
{
    public abstract class BaseDeDatos
    {
        public static List<Vehiculo>ListaVehiculos = new List<Vehiculo>();
        public static List<Cliente>ListaClientes = new List<Cliente>();
        public static List<Alquiler>ListaAlquileres = new List<Alquiler>();
        public static List<Venta>ListaVentas = new List<Venta>();
        public static List<Usuario>ListaUsuarios = new List<Usuario>();

        public static Usuario usuarioLogueado;

        public static void CargarDatosIniciales()
        {
            Usuario usuario = new Usuario();
            usuario.SetNombre("admin");
            usuario.SetContraseña("admin");
            usuario.SetDocumento("11111111");
            usuario.SetTipo("Administrador");
            ListaUsuarios.Add(usuario);

            Usuario Vendedor = new Usuario("11", "Alejandra", "Fernandez", "Vendedor", "11");            
            ListaUsuarios.Add(Vendedor);

            Cliente cliente = new Cliente { Apellido = "Perez", Documento = "45866580", Direccion = "dr Edye 3456", Nombre = "Juan" };
            Cliente cliente2 = new Cliente { Apellido = "Lopez", Documento = "45899989", Direccion = "dr Edye 5585", Nombre = "Javier" };
            Cliente cliente3 = new Cliente { Apellido = "Gomez", Documento = "37854682", Direccion = "Aigua 3588", Nombre = "Luis" };
            ListaClientes.Add(cliente);
            ListaClientes.Add(cliente2);
            ListaClientes.Add(cliente3);

            Moto vehiculo = new Moto { Marca = "Kawasaki", Matricula = "MA458855", Modelo = "Ninja", PrecioVenta = "20000", ImagenUno= "img/Kawasaki-Ninja-300-ii.jpg", ImagenDos= "img/81jSByQFgYL.jpg", ImagenTres= "img/KAWA1182.jpg",
                PrecioAlquiler = "1000", Activo= true};
            vehiculo.SetCampoEspecial("Cilindrada: 1000");
            Auto vehiculo2 = new Auto { Marca = "Ferrari", Matricula = "TG945884", Modelo = "F40", PrecioVenta = "180000", ImagenUno = "img/gas_monkey_f40_01212016.jpg", ImagenDos= "img/Ferrari-F40-Year-1987.jpg", ImagenTres= "img/1991-Ferrari-F40-black-2-630x419.jpg",
                PrecioAlquiler = "2000", Activo = true };
            vehiculo2.SetCampoEspecial("Cant. Pasajeros: 2");
            Camion vehiculo3 = new Camion { Marca = "Scania", Matricula = "FR46665", Modelo = "UNO", PrecioVenta = "250000", ImagenUno = "img/scania-electrico-bateria.jpeg" , ImagenDos= "img/scania2.jpg", ImagenTres= "img/scania3.jpg",
                PrecioAlquiler = "5000", Activo = true , CampoEspecial = "Toneladas: 2000"};            
            ListaVehiculos.Add(vehiculo);
            ListaVehiculos.Add(vehiculo2);
            ListaVehiculos.Add(vehiculo3);            

            Venta venta = new Venta { FechaVenta = DateTime.Now, DocumentoCliente = "45866580", Matricula = "TG945884", 
                DocumentoEmpleado = "11111111", Precio = 175000 };
            ListaVentas.Add(venta);
            Alquiler alquiler = new Alquiler { CantidadDias = 2, FechaRetiro = DateTime.Now, Cedula = "37854682",  
                Matricula = "FR46665", NombreUsuario = "Alejandra", Precio = 10000, Devuelto = false };
            ListaAlquileres.Add(alquiler);        
        }

        public static void GuardarUsuarioLogueado(Usuario usuario)
        {
            usuarioLogueado = usuario;
            if(usuario.GetTipo() == "Administrador")
            {
                usuario.SetVerAlquileres(true);
                usuario.SetVerVentas(true);
                usuario.SetVerCliente(true);
                usuario.SetVerAdministracion(true);
                usuario.SetVerVehiculos(true);
            }
            else if(usuario.GetTipo() == "Vendedor")
            {
                usuario.SetVerAlquileres(true);
                usuario.SetVerCliente(true);
                usuario.SetVerAdministracion(false);
                usuario.SetVerVehiculos(true);
                usuario.SetVerVentas(true);
            }
        }

        public static List <Vehiculo> VehiculosActivos()
        {
            List<Vehiculo> vehiculosActivos = new List<Vehiculo>();
            foreach (var vehiculo in ListaVehiculos)
            {
                if (vehiculo.Activo)
                {
                    vehiculosActivos.Add(vehiculo);
                }
            }
            return vehiculosActivos;
        }

        

       
    }

}