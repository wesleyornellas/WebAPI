﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FCamaraWebAPI.Models;
using FCamaraWebAPI.DAL;
using Dapper;

namespace FCamaraWebAPI.DAL
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario ObterUsuario(string nome)
        {
            return new Usuario();
        }

        public string ObterNomeUsuario(string email, string senha)
        {
            return "nome";
        }

        public bool InserirUsuario(Usuario usuario)
        {
            return true;
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            return true;
        }

        public bool DeletarUsuario(Guid id, string email, string senha)
        {
            return true;
        }
    }
}