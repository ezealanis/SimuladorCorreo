using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaz
{
    public interface IMostrar<T>
    {
        string MostrarDatos(IMostrar<T> elemento);

    }
}
