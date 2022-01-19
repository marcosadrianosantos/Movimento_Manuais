using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModel.Produto;
using MovimentosManuais.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace MovimentosManuais.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository repository;
        private readonly IMapper mapper;

        public ProdutoService(IProdutoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public List<ProdutoViewModel> GetAll()
        {
            try
            {
                return mapper.Map<List<ProdutoViewModel>>(
                    repository.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
