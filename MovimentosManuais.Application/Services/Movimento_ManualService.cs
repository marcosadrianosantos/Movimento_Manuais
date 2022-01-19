using AutoMapper;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.ViewModel.Movimento_Manual;
using MovimentosManuais.Domain.Entities;
using MovimentosManuais.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovimentosManuais.Application.Services
{
    public class Movimento_ManualService : IMovimento_ManualService
    {
        private readonly IMovimento_ManualRepository repository;
        private readonly IMapper mapper;
        private readonly IProdutoRepository produtoRepository;

        public Movimento_ManualService(IMovimento_ManualRepository repository, IMapper mapper, IProdutoRepository produtoRepository)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.produtoRepository = produtoRepository;
        }

        public bool Post(Movimento_ManualViewModel movimentoManual)
        {
            Movimento_Manual _movimento = mapper.Map<Movimento_Manual>(movimentoManual);

            Movimento_Manual _ultimoMovimento = mapper.Map<Movimento_Manual>(repository.Query(wh => wh.DAT_ANO == movimentoManual.DAT_ANO &&
                                                                                                    wh.DAT_MES == movimentoManual.DAT_MES).OrderBy(o => o.NUM_LANCAMENTO).LastOrDefault());

            if (_ultimoMovimento != null)
                _movimento.NUM_LANCAMENTO = _ultimoMovimento.NUM_LANCAMENTO + 1;
            else
                _movimento.NUM_LANCAMENTO = 1;

            if (_movimento.DAT_MES > 12)
                throw new Exception("Valor mês não existente");

            _movimento.COD_USUARIO = "TESTE";
            _movimento.DAT_MOVIMENTO = DateTime.Now;

            repository.Create(_movimento);

            return true;
        }

        public List<Movimento_ManualRequireViewModel> GetAll()
        {
            List<Movimento_Manual> _movimento = mapper.Map<List<Movimento_Manual>>(repository.GetAll());

            List<Movimento_ManualRequireViewModel> _movimentoManual = new List<Movimento_ManualRequireViewModel>();

            foreach (var item in _movimento)
            {
                Produto _produto = mapper.Map<Produto>(produtoRepository.GetByCodProduto(item.COD_PRODUTO));

                _movimentoManual.Add(new Movimento_ManualRequireViewModel
                {
                    DAT_ANO = item.DAT_ANO,
                    DAT_MES = item.DAT_MES,
                    COD_PRODUTO = item.COD_PRODUTO,
                    DES_DESCRICAO = item.DES_DESCRICAO,
                    DES_PRODUTO = _produto.DES_PRODUTO,
                    NUM_LANCAMENTO = item.NUM_LANCAMENTO,
                    VAL_VALOR = item.VAL_VALOR
                });
            }

            return _movimentoManual;
        }
    }
}
