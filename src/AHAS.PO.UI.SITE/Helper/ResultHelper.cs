using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHAS.PO.UI.SITE.Helper
{
    public class ResultHelper
    {
        public ResultHelper()
        {
            Sucess = false;
            Error = new List<string>();
        }

        public bool Sucess { get; set; }
        public List<string> Error { get; set; }
    }
}