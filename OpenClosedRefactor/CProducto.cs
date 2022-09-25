namespace OpenClosedRefactor
{
    public class CProducto
    {
        public string Nombre { get; set; }
        public int Categoria { get; set; }
        public double Precio { get; set; }

        public CProducto(string nombre, int categoria, double precio)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
        }

        public override string ToString()
        {
            return string.Format("El producto {0} cuesta {1}", Nombre, Precio);
        }
    }
}
