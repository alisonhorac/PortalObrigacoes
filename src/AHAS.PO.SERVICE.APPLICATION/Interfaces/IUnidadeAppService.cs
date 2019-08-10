using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System.Collections.Generic;

namespace AHAS.PO.SERVICE.APPLICATION.Interfaces
{
    public interface IUnidadeAppService
    {
        UnidadeViewModel Alterar(UnidadeViewModel obj);
        bool Excluir(long id);
        UnidadeViewModel Inserir(UnidadeViewModel obj);
        UnidadeViewModel Consultar(long id);
        IEnumerable<UnidadeViewModel> Listar();
    }
}
