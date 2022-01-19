using MovimentosManuais.Application.ViewModel.Produto;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Interfaces
{
    public interface IProdutoService
    {
        List<ProdutoViewModel> GetAll();
    }
}
