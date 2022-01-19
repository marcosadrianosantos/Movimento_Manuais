using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Interfaces
{
    public interface IProdutoRepository: IRepository<Produto>
    {
        List<Produto> GetAll();
        Produto GetByCodProduto(string codProduto);
        Produto GetByDescProduto(string descProduto);
    }
}
