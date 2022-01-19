using Microsoft.EntityFrameworkCore;
using MovimentosManuais.Data.Mappings;
using MovimentosManuais.Domain.Entities;

namespace MovimentosManuais.Data.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options)
            :base(options) { }

        public DbSet<Movimento_Manual> MovimentosManuais { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto_Cosif> ProdutosCosifs{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Movimento_ManualMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new Produto_CosifMap());

            SeedData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            Produto[] _produtos = new[]
            {
                new Produto{COD_PRODUTO = "0001", DES_PRODUTO = "DESC 0001", STA_STATUS = "A" },
                new Produto{COD_PRODUTO = "0002", DES_PRODUTO = "DESC 0002", STA_STATUS = "A" },
                new Produto{COD_PRODUTO = "0003", DES_PRODUTO = "DESC 0003", STA_STATUS = "A" }
            };

            Produto_Cosif[] _produto_Cosifs = new[]
            {
                new Produto_Cosif{COD_PRODUTO = "0001", COD_COSIF = "48408352091", COD_CLASSIFICACAO = "TESTE1", STA_STATUS = "A"},
                new Produto_Cosif{COD_PRODUTO = "0002", COD_COSIF = "42537728033", COD_CLASSIFICACAO = "TESTE2", STA_STATUS = "A"},
                new Produto_Cosif{COD_PRODUTO = "0003", COD_COSIF = "07161383013", COD_CLASSIFICACAO = "TESTE3", STA_STATUS = "A"},
                new Produto_Cosif{COD_PRODUTO = "0003", COD_COSIF = "14470492094", COD_CLASSIFICACAO = "TESTE4", STA_STATUS = "A"},
                new Produto_Cosif{COD_PRODUTO = "0002", COD_COSIF = "25767337004", COD_CLASSIFICACAO = "TESTE5", STA_STATUS = "A"},
                new Produto_Cosif{COD_PRODUTO = "0001", COD_COSIF = "38809386019", COD_CLASSIFICACAO = "TESTE6", STA_STATUS = "A"}
            };

            modelBuilder.Entity<Produto>().HasData(_produtos);
            modelBuilder.Entity<Produto_Cosif>().HasData(_produto_Cosifs);
        }
    }
}
