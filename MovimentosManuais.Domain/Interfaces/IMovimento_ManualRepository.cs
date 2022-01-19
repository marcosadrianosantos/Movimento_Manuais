using MovimentosManuais.Domain.Entities;
using System.Collections.Generic;

namespace MovimentosManuais.Domain.Interfaces
{
    public interface IMovimento_ManualRepository: IRepository<Movimento_Manual>
    {
        List<Movimento_Manual> GetAll();
    }
}
