using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BaseService<T, J> : IService<J> where T : BaseRepository<J> where J : class
    {
        protected T repo;
        public BaseService(Contexto contexto)
        {
            Contexto ctx = contexto;
            repo = Activator.CreateInstance(typeof(T), new object[] { contexto }) as T;
        }
        public virtual J ObtenerPorId(int id)
        {
            return repo.ObtenerPorId(id);
        }

        public virtual List<J> ObtenerTodos()
        {
            return repo.ObtenerTodos();
        }
    }
}
