namespace LiskovRefactor
{
    // Hacemos uso del polimorfismo
    public class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje)
        {
        }

        public override void Mostrar()
        {
            Console.WriteLine("Radio: " + mensaje);
        }
    }
}
