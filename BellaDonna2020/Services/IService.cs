using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    interface IService<T>
    {

        List<T> ObtenerTodos();

        T ObtenerPorId(int id);

    }
}
