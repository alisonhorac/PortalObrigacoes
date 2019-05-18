using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AHAS.PO.INFRA.CROSS.GLOBALIZING;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModel
{
    public class UnidadeViewModel
    {
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Nome { get; set; }
    }
}
