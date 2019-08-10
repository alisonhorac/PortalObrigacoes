using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Unidade
    {
        public Unidade()
        {
            MensagemValidacao = new List<string>();
            ResponsaveisDocumentos = new HashSet<ResponsavelDocumento>();
        }

        public long IDUnidade { get; set; }

        public string CNPJ { get; set; }

        public string InscricaoEstadual { get; set; }

        public string Nome { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool FlagAtivo { get; set; }

        //RELACIONAMENTO
        public virtual ICollection<ResponsavelDocumento> ResponsaveisDocumentos { get; set; }

        public virtual Agendamento Agendamento { get; set; }

        //Mensagens de validação
        public List<String> MensagemValidacao { get; set; }
        public bool Sucesso { get; set; }
    }
}
