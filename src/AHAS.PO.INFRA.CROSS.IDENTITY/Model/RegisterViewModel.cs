using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class RegisterViewModel
    {
        [Display(Name = "Nome")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MaxLenght")]
        [MinLength(5, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MinLenght")]
        [DataType(DataType.Text)]
        public string NameIdentifier { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Email_Validator")]
        public string Email { get; set; }

        [Display(Name = "DDI")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [StringLength(3, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Lenght_Equal", MinimumLength = 3)]
        public string DDIPhone { get; set; }

        [Display(Name = "DDD")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [StringLength(2, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Lenght_Equal", MinimumLength = 2)]
        public string DDDPhone { get; set; }

        [Display(Name = "Celular")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [StringLength(9, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Lenght", MinimumLength = 8)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [StringLength(16, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Lenght", MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Repita a senha")]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [Compare("Password", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Compare")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Termos")]
        [Range(typeof(bool), "true", "true", ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Checkbox")]
        public bool Terms { get; set; }
    }
}