using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModel
{
    public class DocumentoViewModel
    {
        public string Nome { get; set; }
        public Guid IDOrigem { get; set; }
        public Guid IDPeriodicidade { get; set; }
        public int PrazoDiasVencimento { get; set; }
        public int PrazoMesVencimento { get; set; }
        public bool FlagDiasUteisVencimento { get; set; }
        public int PrazoDiasAlerta { get; set; }
        public DateTime DataReferencia { get; set; }
        public Origem Origem { get; set; }
        public Periodicidade Periodicidade { get; set; }
    }
}
