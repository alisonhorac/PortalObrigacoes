using System;
using System.Collections.Generic;
using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Service;
using AHAS.PO.SERVICE.APPLICATION.Interface;

namespace AHAS.PO.SERVICE.APPLICATION.AppService
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public bool Desativar(Guid id)
        {
            return _usuarioService.Desativar(id);
        }

        public void DesativarLock(string id)
        {
            _usuarioService.DesativarLock(id);
        }

        public Usuario ObterPorId(string id)
        {
            return _usuarioService.ObterPorId(id);
        }

        public IEnumerable<Usuario> ObterTodos()
        {
            return _usuarioService.ObterTodos();
        }
    }
}
