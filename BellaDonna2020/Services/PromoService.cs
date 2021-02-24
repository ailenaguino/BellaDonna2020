using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PromoService : BaseService<PromoRepository, Promos>
    {
        PromoRepository PR;

        public PromoService(Contexto ctx) : base(ctx)
        {
            PR = new PromoRepository(ctx);
        }
    }
}
