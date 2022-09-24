namespace SingleResponsibility
{
    public class CEmpleado
    {
        private string puesto;
        private int edad;
        public string Nombre { get; set; }
        public double Salario { get; set; }

        public CEmpleado(string nombre, string puesto, int edad, double salario)
        {
            Nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            Salario = salario;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                                 Nombre, puesto, edad, Salario);
        }


        /* Incumpliendo el principio de responsabilidad única
            * Esta clase tiene dos responsabilidades
            * Lo correcto sería crear una clase independiente que se encargue de realizar estos procesos.
            * En la clase de CHacienda se estaría viendo la manera correcta de como hacerlo.
        */

        /*public double CalcularImpuesto()
        {
            return salario * 0.35;
        }

        public void PagarImpuesto()
        {
            double imp = CalcularImpuesto();
            Console.WriteLine("Se pagó {0} de impuestos, por parte de {1}", imp, nombre);
        }*/
    }
}
