namespace InterfaceSegregation
{
    /*
     * Esta clase no representa nigún problema
     */ 
    public class MultiAvanzado : IMutifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Escanear");
        }

        public void Faxear()
        {
            Console.WriteLine("Faxear");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        public void Telefono()
        {
            Console.WriteLine("Telefono");
        }
    }
}
