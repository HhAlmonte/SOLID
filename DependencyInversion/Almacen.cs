using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Almacen
    {
        // Nos vemos forzados a crear la propiedad para que se cuenta contar el inventario
        // Al ser una propiedad de tipo List forzamos a Auditor a trabajar con una lista
        public List<Producto> Inventario { get; set; }
        
        public Almacen()
        {
            Inventario = new List<Producto>();
        }
        
        public void AdicionarProducto(Producto producto)
        {
            Inventario.Add(producto);
            Console.WriteLine("Producto {0} agregado al inventario", producto.Nombre);
        }
    }
}
