namespace InterfaceSegregation
{
    // En esta clase no se utilizan todos los metodos de la interfaz
    // IMutifuncional, por lo tanto, es mejor crear una interfaz nueva
    // que solo contenga los metodos que se van a utilizar.

    public class MultiSencillo : IMutifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Escanear");
        }

        public void Faxear()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        public void Telefono()
        {
            throw new NotImplementedException();
        }
    }
}
