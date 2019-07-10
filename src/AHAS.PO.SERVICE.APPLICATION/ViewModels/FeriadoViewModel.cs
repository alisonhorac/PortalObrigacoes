using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModels
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

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [DisplayName("Período do Feriado")]
        public string PeriodoDeAte { get; set; }

        [DisplayName("Feriado Fixo")]
        public bool FlagFeriadoFixo { get; set; }

        [DisplayName("Feriado Fixo")]
        public string DescricaoFlagFeriadoFixo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [DisplayName("Abrangência")]
        public int IDAbrangencia { get; set; }

        [DisplayName("Abrangência")]
        public string DescricaoAbrangencia { get; set; }

        [DisplayName("Estado")]
        public int? IDEstado { get; set; }

        public string DescricaoEstado { get; set; }

        public bool HabilitaEstado { get; set; }

        public IEnumerable<AbrangenciaViewModel> ListaAbrangencia { get; set; }

        public IEnumerable<EstadoViewModel> ListaEstado { get; set; }
    }
}
