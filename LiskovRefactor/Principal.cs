namespace LiskovRefactor
{
    // El principio de Liskov es un principio de diseño orientado a objetos que dice que:
    // "Si S es un subtipo de T, entonces los objetos de tipo T en un programa pueden ser reemplazados por objetos de tipo S sin alterar ninguna de las propiedades deseables de ese programa."
    // En otras palabras, las clases derivadas deben ser sustituibles por sus clases base.
    // El principio de Liskov es una extensión del principio de sustitución de Liskov (LSP).
    public abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        // Método abstracto que será implementado por las clases hijas
        public abstract void Mostrar();
    }
}
