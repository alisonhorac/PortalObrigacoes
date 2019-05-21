using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Email_Validator")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
    }
}
