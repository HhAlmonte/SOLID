namespace LiskovRefactor
{
    // Hacemos uso del polimorfismo
    public class Noticiero : Principal
    {
        public Noticiero(string mensaje) : base(mensaje)
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Noticiero: " + mensaje);
        }
    }
}
