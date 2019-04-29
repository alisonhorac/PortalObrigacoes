using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class DocumentoService : IDocumentoService
    {
        private readonly IDocumentoRepository repository;

        public DocumentoService(IDocumentoRepository documentoRepository)
        {
            repository = documentoRepository;
        }

        public Documento Alterar(Documento obj)
        {
            return repository.Alterar(obj);
        }

        public Documento Consultar(Guid id)
        {
            return repository.Consultar(id);
        }

        public bool Desativar(Guid id)
        {
            return repository.Desativar(id);
        }

        public Documento Inserir(Documento obj)
        {
            return repository.Inserir(obj);
        }

        public IEnumerable<Documento> Listar()
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
