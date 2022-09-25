namespace InterfaceSegregationRefactor
{
    public class Fax : IFax
    {
        public void Faxear()
        {
            Console.WriteLine("Fax");
        }

        public void Telefono()
        {
            Console.WriteLine("Telefono");
        }
    }
}
