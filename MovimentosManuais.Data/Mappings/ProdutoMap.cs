using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovimentosManuais.Domain.Entities;

namespace MovimentosManuais.Data.Mappings
{
    public class ProdutoMap: IEntityTypeConfiguration<Produto> 
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.COD_PRODUTO);

            builder.Property(e => e.DES_PRODUTO)
                   .HasColumnType("VARCHAR(30)")
                   .IsRequired();

            builder.Property(e => e.STA_STATUS)
                   .HasColumnType("CHAR(1)")
                   .IsRequired();

        }
    }
}
