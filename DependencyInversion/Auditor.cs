namespace DependencyInversion
{
    public class Auditor
    {
        private Almacen almacen;

        public Auditor(Almacen almacen)
        {
            this.almacen = almacen;
        }

        public double totalesAlimentos()
        {
            double total = 0;
            foreach (Producto producto in almacen.Inventario)
            {
                if (producto.Tipo == 0)
                {
                    total += producto.Costo;
                }
            }
            return total;
        }
    }
}
