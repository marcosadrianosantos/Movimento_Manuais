using MovimentosManuais.Data.Context;
using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MovimentosManuais.Data.Repositories
{
    public class Produto_CosifRepository: Repository<Produto_Cosif>, IProduto_CosifRepository
    {
        public Produto_CosifRepository(MySQLContext context)
           : base(context) { }

        public List<Produto_Cosif> GetByCodProduto(string codProduto)
        {
            return Query(x => x.COD_PRODUTO == codProduto).ToList();
        }
    }
}
