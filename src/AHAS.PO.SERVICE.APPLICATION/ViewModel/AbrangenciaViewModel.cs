using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModel
{
    public class AbrangenciaViewModel
    {
        [Key]
        public int IDAbrangencia { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }
    }
}
