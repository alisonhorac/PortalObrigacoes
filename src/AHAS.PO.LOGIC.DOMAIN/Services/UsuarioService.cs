using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            this.repository = repository;
        }

        public bool Desativar(Guid id)
        {
            return repository.Desativar(id);
        }

        public void DesativarLock(string id)
        {
           repository.DesativarLock(id);
        }

        public Usuario ObterPorId(string id)
        {
            return repository.ObterPorId(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return repository.ObterTodos();
        }
    }
}
