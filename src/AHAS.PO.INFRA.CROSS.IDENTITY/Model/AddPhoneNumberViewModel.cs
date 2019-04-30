using System.ComponentModel.DataAnnotations;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}