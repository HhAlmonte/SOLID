namespace OpenClosedRefactor
{
    public class CInventarioMedicamento : CBaseInventario
    {
        public CInventarioMedicamento(CProducto producto) : base(producto)
        {
        }

        // Sobrescribimo el metodo CalcularProducto
        public override double CalcularProducto()
        {
            Producto.Precio *= 0.8;
            return Producto.Precio;
        }
    }
}
