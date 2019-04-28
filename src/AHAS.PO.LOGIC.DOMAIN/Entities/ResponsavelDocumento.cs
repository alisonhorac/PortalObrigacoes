using System;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class ResponsavelDocumento
    {
        public int PrazoDiasVencimento { get; set; }

        public int PrazoMesVencimento { get; set; }

        public bool FlagDiasUteisVencimento { get; set; }

        public DateTime DataReferencia { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataAtualizacao { get; set; }

        //RELACIONAMENTO
        public Guid IDUnidade { get; set; }
        public virtual Unidade Unidade { get; set; }

        public Guid IDDocumento { get; set; }
        public virtual Documento Documento { get; set; }

        public string Id { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
