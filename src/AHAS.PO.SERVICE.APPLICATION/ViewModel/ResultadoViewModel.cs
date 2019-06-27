using System.Collections.Generic;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModel
{
    public class ResultadoViewModel
    {
        public ResultadoViewModel()
        {
            Sucesso = false;
            Erros = new List<string>();
        }

        public bool Sucesso { get; set; }
        public List<string> Erros { get; set; }
        public object Objeto { get; set; }
    }
}
