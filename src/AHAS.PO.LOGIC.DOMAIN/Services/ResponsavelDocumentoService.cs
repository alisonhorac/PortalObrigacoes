using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class ResponsavelDocumentoService :  IResponsavelDocumentoService
    {
        private readonly IResponsavelDocumentoRepository repository;

        public ResponsavelDocumentoService(IResponsavelDocumentoRepository responsavelDocumentoRepository)
        {
            repository = responsavelDocumentoRepository;
        }

        public ResponsavelDocumento Inserir(ResponsavelDocumento obj)
        {
            return repository.Inserir(obj);
        }

        public ResponsavelDocumento Alterar(ResponsavelDocumento obj)
        {
            return repository.Alterar(obj);
        }

        public ResponsavelDocumento Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public bool Excluir(Guid id)
        {
            return repository.Excluir(id);
        }

        public IEnumerable<ResponsavelDocumento> Listar()
        {
            return repository.Listar();
        }

        public void Dispose()
        {
            repository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
