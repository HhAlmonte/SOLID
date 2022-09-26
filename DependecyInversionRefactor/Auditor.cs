using DependencyInversionRefactor;

namespace DependecyInversionRefactor
{
    public class Auditor
    {
        private IAuditable _almacen;

        // Ahora el editor está fuertemente acoplado con el almacen
        public Auditor(IAuditable almacen)
        {
            _almacen = almacen;
        }
        
        public double totalAlimento()
        {
            double total = 0;

            IEnumerable<Producto> listado = _almacen.ObtenProductor(0);

            foreach (Producto p in listado)
            {
                Console.WriteLine(p);
                total += p.Costo;
            }

            return total;
        }
    }
}
