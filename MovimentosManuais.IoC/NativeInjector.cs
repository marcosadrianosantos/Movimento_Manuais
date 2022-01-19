using Microsoft.Extensions.DependencyInjection;
using MovimentosManuais.Application.Interfaces;
using MovimentosManuais.Application.Services;
using MovimentosManuais.Data.Repositories;
using MovimentosManuais.Domain.Interfaces;

namespace MovimentosManuais.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Service

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProduto_CosifService, Produto_CosifService>();
            services.AddScoped<IMovimento_ManualService, Movimento_ManualService>();

            #endregion

            #region Repository

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProduto_CosifRepository, Produto_CosifRepository>();
            services.AddScoped<IMovimento_ManualRepository, Movimento_ManualRepository>();

            #endregion
        }
    }
}
