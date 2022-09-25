namespace InterfaceSegregationRefactor
{
    public class MultiSencillo : IMultiBasico
    {
        public void Escanear()
        {
            Console.WriteLine("Escanear");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }
    }
}
