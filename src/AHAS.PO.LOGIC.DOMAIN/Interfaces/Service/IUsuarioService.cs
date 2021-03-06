﻿using AHAS.PO.LOGIC.DOMAIN.Entities;
using System;
using System.Collections.Generic;

namespace AHAS.PO.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IUsuarioService
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
        bool Desativar(Guid id);
    }
}
