using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationRefactor
{
    // Interface que define las operaciones básicas de un Multi
    public interface IMultiBasico
    {
        void Imprimir();
        void Escanear();
    }
}
