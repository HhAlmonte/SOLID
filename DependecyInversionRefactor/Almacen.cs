using DependencyInversionRefactor;

namespace DependecyInversionRefactor
{
    public class Almacen : IAuditable
    {
        private List<Producto> inventario;
        
        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine("Agregamos el producto {0} al inventario", producto.Nombre);
        }

        public IEnumerable<Producto> ObtenProductor(int tipo)
        {
            List<Producto> productos = new List<Producto>();
            
            foreach (Producto producto in inventario)
            {
                if (producto.Tipo == tipo)
                    productos.Add(producto);
            }

            return productos;
        }
    }
}
