using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IProducto
    {
        string Descripcion
        {
            get;
        }

        int Cantidad
        {
            get;
        }
    }
}
