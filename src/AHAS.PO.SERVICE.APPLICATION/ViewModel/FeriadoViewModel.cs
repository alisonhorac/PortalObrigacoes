using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModel
{
    public class FeriadoViewModel
    {
        public string Descricao { get; set; }
        public bool FlagFeriadoFixo { get; set; }
        public DateTime DataDe { get; set; }
        public DateTime DataAte { get; set; }
        public Abrangencia Abrangencia { get; set; }
    }
}
