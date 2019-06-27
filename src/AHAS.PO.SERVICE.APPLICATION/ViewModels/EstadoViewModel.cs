using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModels
{
    public class EstadoViewModel
    {
        [Key]
        public int IDEstado { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Sigla")]
        public string Sigla { get; set; }
    }
}
