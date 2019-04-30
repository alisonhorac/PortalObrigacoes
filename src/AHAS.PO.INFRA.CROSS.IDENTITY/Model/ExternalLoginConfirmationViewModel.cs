using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}