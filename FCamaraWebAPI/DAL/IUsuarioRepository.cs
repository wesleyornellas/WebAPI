using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FCamaraWebAPI.Models;

namespace FCamaraWebAPI.DAL
{
    internal interface IUsuarioRepository
    {
        Usuario ObterUsuario(string nome);

        string ObterNomeUsuario(string email, string senha);

        bool InserirUsuario(Usuario usuario);

        bool AtualizarUsuario(Usuario usuario);

        bool DeletarUsuario(Guid id, string email, string senha);
    }
}