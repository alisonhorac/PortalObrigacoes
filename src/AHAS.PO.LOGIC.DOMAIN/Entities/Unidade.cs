using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Unidade
    {

        public Unidade()
        {
            IDUnidade = Guid.NewGuid();
            ResponsaveisDocumentos = new HashSet<ResponsavelDocumento>();
        }

        public Guid IDUnidade { get; set; }

        public string CNPJ { get; set; }

        public string InscricaoEstadual { get; set; }

        public string Nome { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool FlagAtivo { get; set; }

        //RELACIONAMENTO
        public virtual ICollection<ResponsavelDocumento> ResponsaveisDocumentos { get; set; }

        public virtual Agendamento Agendamento { get; set; }
    }
}
