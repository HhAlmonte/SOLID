namespace OpenClosedRefactor
{
    public class CTienda
    {
        private List<CBaseInventario> productos;

        public CTienda(List<CBaseInventario> cp)
        {
            productos = cp;
        }

        // Método que calcula el precio total de la compra
        public void calcularInventario()
        {
            double total = 0;

            foreach (var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }

            Console.WriteLine("El total del inventario es: {0}", total);
        }
    }
}
