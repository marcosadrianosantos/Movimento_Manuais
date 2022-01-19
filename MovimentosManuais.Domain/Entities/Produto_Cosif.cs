﻿using System.Collections.Generic;

namespace MovimentosManuais.Domain.Entities
{
    public class Produto_Cosif
    {
        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
        public ICollection<Movimento_Manual> Contatos { get; set; }
    }
}
