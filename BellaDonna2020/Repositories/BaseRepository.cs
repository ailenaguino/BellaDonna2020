using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected Contexto ctx;
        DbSet<T> dbSet;

        public BaseRepository(Contexto contexto)
        {
            ctx = contexto;
            dbSet = ctx.Set<T>();
        }


        public virtual List<T> ObtenerTodos()
        {
            return dbSet.ToList();
        }

        public virtual T ObtenerPorId(int id)
        {
            T p = dbSet.Find(id);

            return p;
        }

    }
}
