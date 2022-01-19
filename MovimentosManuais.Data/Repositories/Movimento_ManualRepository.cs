using MovimentosManuais.Data.Context;
using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MovimentosManuais.Data.Repositories
{
    public class Movimento_ManualRepository : Repository<Movimento_Manual>, IMovimento_ManualRepository
    {
        public Movimento_ManualRepository(MySQLContext context)
           : base(context) { }

        public List<Movimento_Manual> GetAll()
        {
            return Query(wh => true).ToList();
        }
    }
}
