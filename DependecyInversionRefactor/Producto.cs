namespace DependencyInversionRefactor
{
    // Dependency Inversion Principle
    // Principio de Inversión de Dependencias
    // Las clases de alto nivel no deben depender de las clases de bajo nivel. Ambas deben depender de abstracciones.
    // Las abstracciones no deben depender de los detalles. Los detalles deben depender de las abstracciones.
    
    public class Producto
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }
        public double Costo { get; set; }

        public Producto(string nombre, int tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Costo = costo;
        }
        
        public override string ToString()
        {
            string strTipo = "";

            switch (Tipo)
            {
                case 0:
                    strTipo = "Alimento";
                    break;
                case 1:
                    strTipo = "Medicina";
                    break;
                case 2:
                    strTipo = "Ropa";
                    break;
                default:
                    break;
            }

            return String.Format("{0}, tipo {1}, costo ${2}", Nombre, strTipo, Costo);
        }
    }
}
