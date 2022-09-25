namespace Liskov
{
    // Principio de sustitución de Liskov
    public class Noticiero
    {
        protected string mensaje;

        public Noticiero(string mensaje)
        {
            this.mensaje = mensaje;
        }

        public void Mostrar()
        {
            Console.WriteLine("Desde el noticiero: {0}",mensaje);
        }
    }
}
