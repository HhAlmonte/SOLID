namespace InterfaceSegregationRefactor
{
    public class MultiAvanzado : IMultiCompleto
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        public void Escanear()
        {
            Console.WriteLine("Escanear");
        }

        public void Faxear()
        {
            Console.WriteLine("Faxear");
        }

        public void Telefono()
        {
            Console.WriteLine("Telefono");
        }
    }

}
