using MovimentosManuais.Application.ViewModel.Produto_Cosif;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Interfaces
{
    public interface IProduto_CosifService
    {
        List<Produto_CosifViewModel> GetByCodProduto(string codProduto);
    }
}
