using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModel.Produto_Cosif;
using MovimentosManuais.Domain.Interfaces;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Services
{
    public class Produto_CosifService: IProduto_CosifService
    {
        private readonly IProduto_CosifRepository repository;
        private readonly IMapper mapper;

        public Produto_CosifService(IProduto_CosifRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<Produto_CosifViewModel> GetByCodProduto(string codProduto)
        {
                
            return mapper.Map<List<Produto_CosifViewModel>>(repository.GetByCodProduto(codProduto));
        }
    }
}
