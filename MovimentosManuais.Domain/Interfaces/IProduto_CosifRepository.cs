using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Interfaces
{
    public interface IProduto_CosifRepository: IRepository<Produto_Cosif>
    {
        List<Produto_Cosif> GetByCodProduto(string codProduto);
    }
}
