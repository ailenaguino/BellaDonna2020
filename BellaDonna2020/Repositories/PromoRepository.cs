using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PromoRepository : BaseRepository<Promos>
    {
        public PromoRepository(Contexto ctx) : base(ctx) { }
    }
    
}
