using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.LOGIC.DOMAIN.Entities
{
    public class Estado
    {
        public int IDEstado { get; set; }

        public string Descricao { get; set; }

        public string Sigla { get; set; }

        //RELACIONAMENTO
        public virtual ICollection<Feriado> Feriados { get; set; }
    }
}
