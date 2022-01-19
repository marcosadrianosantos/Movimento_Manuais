using MovimentosManuais.Application.ViewModel.Movimento_Manual;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Interfaces
{
    public interface IMovimento_ManualService
    {
        bool Post(Movimento_ManualViewModel movimentoManual);
        List<Movimento_ManualRequireViewModel> GetAll();
    }
}
