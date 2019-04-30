using System.Collections.Generic;

namespace AHAS.PO.INFRA.CROSS.IDENTITY.Model
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}