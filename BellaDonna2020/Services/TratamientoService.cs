using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TratamientoService : BaseService<TratamientoRepository, Tratamientos>
    {

        TratamientoRepository TR;

        public TratamientoService(Contexto ctx) : base(ctx)
        {
            TR = new TratamientoRepository(ctx);
        }
    }
}
