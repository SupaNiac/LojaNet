﻿using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.DAL
{
    // Cliente: Acesso a Dados
    // Data Access Layer

    public class ClienteDAL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorID(string id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

