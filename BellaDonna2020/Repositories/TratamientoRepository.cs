using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class TratamientoRepository : BaseRepository<Tratamientos>
    {

        public TratamientoRepository(Contexto ctx) : base(ctx) { }
    }
}
