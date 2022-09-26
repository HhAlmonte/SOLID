using DependencyInversionRefactor;

namespace DependecyInversionRefactor
{
    // Todo aquel que necesita ser auditado debe implementar esta interfaz
    public interface IAuditable
    {
        IEnumerable<Producto> ObtenProductor(int tipo);
    }
}
