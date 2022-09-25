namespace Liskov
{
    // Principio de sustitución de Liskov
    // La clase Radio hereda de Noticiero
    public class Radio : Noticiero
    {
        public Radio(string mensaje) : base(mensaje)
        {
        }
        
        public new void Mostrar()
        {
            Console.WriteLine("Desde la radio: {0}", mensaje);
        }
    }
}
