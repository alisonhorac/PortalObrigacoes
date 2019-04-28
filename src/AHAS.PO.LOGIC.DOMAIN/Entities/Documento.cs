using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Documento
    {

        public Documento()
        {
            IDDocumento = Guid.NewGuid();
            ResponsaveisDocumentos = new HashSet<ResponsavelDocumento>();
        }

        public Guid IDDocumento { get; set; }

        public string Nome { get; set; }

        public virtual Origem Origem { get; set; }

        public virtual Periodicidade Periodicidade { get; set; }

        public int PrazoDiasVencimento { get; set; }

        public int PrazoMesVencimento { get; set; }

        public bool FlagDiasUteisVencimento { get; set; }

        public int PrazoDiasAlerta { get; set; }

        public DateTime DataReferencia { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool FlagAtivo { get; set; }

        //RELACIONAMENTOS
        public virtual ICollection<ResponsavelDocumento> ResponsaveisDocumentos { get; set; }

        public virtual Agendamento Agendamento { get; set; }
    }
}
