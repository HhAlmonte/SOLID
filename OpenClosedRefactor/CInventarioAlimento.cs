namespace OpenClosedRefactor
{
    public class CInventarioAlimento : CBaseInventario
    {
        public CInventarioAlimento(CProducto producto) : base(producto)
        {
        }

        // Sobreescribimos el metodo CalcularProducto
        public override double CalcularProducto()
        {
            Producto.Precio *= 1.2;
            return Producto.Precio;
        }
    }
}
