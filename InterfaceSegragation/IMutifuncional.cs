namespace InterfaceSegregation
{
    /*
     * Interface Segregation Principle
     * Agregando todos los metodos en una sola interfaz
     * es una mala practica, ya que no todas las clases
     * que implementen esta interfaz van a necesitar
     * todos los metodos.
     * Por lo tanto, es mejor separar la interfaz en
     * varias interfaces mas pequeñas.
     * 
     * Verás un ejemplo de lo que estoy explicando en las
     * demás clases de este proyecto.
     */
     
    public interface IMutifuncional
    {
        void Imprimir();
        void Escanear();
        void Telefono();
        void Faxear();
    }
}
