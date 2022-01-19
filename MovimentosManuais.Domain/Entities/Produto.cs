using System.Collections.Generic;

namespace MovimentosManuais.Domain.Entities
{
    public class Produto
    {
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
        public ICollection<Produto_Cosif> Produto_Cosifs { get; set; }
    }
}
