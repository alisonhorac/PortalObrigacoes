using AHAS.PO.LOGIC.DOMAIN.Validator.Feriado;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Feriado
    {
        public Feriado()
        {
            MensagemValidacao = new List<string>();
        }

        public long IDFeriado { get; set; }

        public string Descricao { get; set; }

        public bool FlagFeriadoFixo { get; set; }

        public DateTime DataDe { get; set; }

        public DateTime DataAte { get; set; }

        //RELACIONAMENTO
        public int IDAbrangencia { get; set; }
        public virtual Abrangencia Abrangencia { get; set; }
        public virtual IEnumerable<Abrangencia> ListaAbrangencia { get; set; }

        public int? IDEstado { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual IEnumerable<Estado> ListaEstado { get; set; }

        //Mensagens de validação
        public List<String> MensagemValidacao { get; set; }
        public bool Sucesso { get; set; }
    }
}
