namespace OpenClosed
{
    public class CTienda
    {
        private List<CProducto> _productos;

        public CTienda(List<CProducto> cProductos)
        {
            _productos = cProductos;
        }

        /*
         * Rompiendo el principio de Open Closed
         * Cada que querramos agregar un nuevo requerimiento debemos cambiar el codigo del metodo
         * Esto no debe ser así, ya que el codigo debe ser abierto a la extension pero cerrado a la modificacion
         * Para solucionar esto, haremos uso del polimorfismo
         */
        public void calcularInventario()
        {
            double total = 0;

            foreach (CProducto producto in _productos)
            {
                if (producto.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    producto.Precio *= 0.8;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
                if (producto.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    producto.Precio *= 1.2;
                    Console.WriteLine(producto);
                    total += producto.Precio;
                }
            }

            Console.WriteLine("El total del inventario es: {0}", total);
        }
    }
}
