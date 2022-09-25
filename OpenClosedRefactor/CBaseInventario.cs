namespace OpenClosedRefactor
{
    public abstract class CBaseInventario
    {
        public CProducto Producto { get; set; }

        public CBaseInventario(CProducto producto)
        {
            Producto = producto;
        }

        public override string ToString()
        {
            return Producto.ToString();
        }

        // Metodo abstracto que sera implementado por las clases hijas
        public abstract double CalcularProducto();
    }
}
