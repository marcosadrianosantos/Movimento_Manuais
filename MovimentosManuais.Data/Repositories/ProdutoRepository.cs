using MovimentosManuais.Data.Context;
using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MovimentosManuais.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MySQLContext context)
           : base(context) { }

        public List<Produto> GetAll()
        {
            return Query(x => x.STA_STATUS == "A").ToList();
        }

        public Produto GetByCodProduto(string codProduto)
        {
            return Find(x => x.COD_PRODUTO == codProduto);
        }

        public Produto GetByDescProduto(string descProduto)
        {
            return Query(x => x.DES_PRODUTO.Contains(descProduto)).FirstOrDefault();
        }
    }
}
