using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome da Role")]
        public string Name { get; set; }
    }
}