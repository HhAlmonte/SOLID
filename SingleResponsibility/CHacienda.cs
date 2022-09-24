namespace SingleResponsibility
{
    public class CHacienda
    {
        // Se debe crear una clase especializada para la otra responsabilidad
        // Ahora cada clase cuenta con una sola responsabilidad
        
        public static double CalcularImpuesto(CEmpleado cEmpleado)
        {
            return cEmpleado.Salario * 0.35;
        }
        
        public static void PagarImpuesto(CEmpleado cEmpleado)
        {
            double imp = CalcularImpuesto(cEmpleado);
            Console.WriteLine("Se pagó {0} en impuestos por parte de {1}", imp, cEmpleado.Nombre);
        }
    }
}
