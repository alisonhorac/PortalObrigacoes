using AHAS.PO.INFRA.CROSS.GLOBALIZING;
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
        [Key]
        public int IDFeriado { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [MaxLength(200, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MaxLenght")]
        [MinLength(2, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MinLenght")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Feriado Fixo")]
        public bool FlagFeriadoFixo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [DisplayName("Abrangência")]
        public int IDAbrangencia { get; set; }
    }
}
