using AutoMapper;
using MovimentosManuais.Application.ViewModel.Movimento_Manual;
using MovimentosManuais.Application.ViewModel.Produto;
using MovimentosManuais.Application.ViewModel.Produto_Cosif;
using MovimentosManuais.Domain.Entities;

namespace MovimentosManuais.Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<ProdutoViewModel, Produto>();
            CreateMap<Produto_CosifViewModel, Produto_Cosif>();
            CreateMap<Movimento_ManualViewModel, Movimento_Manual>();
            CreateMap<Movimento_ManualRequireViewModel, Movimento_Manual>();

            #endregion

            #region DomainToViewModel

            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Produto_Cosif, Produto_CosifViewModel>();
            CreateMap<Movimento_Manual, Movimento_ManualViewModel>();
            CreateMap<Movimento_Manual, Movimento_ManualRequireViewModel>();

            #endregion
        }
    }
}
