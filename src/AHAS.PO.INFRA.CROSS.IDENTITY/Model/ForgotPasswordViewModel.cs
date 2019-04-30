using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
