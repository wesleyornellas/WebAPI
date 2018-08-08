using System;
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
        private readonly IDbConnection _db;

        public UsuarioRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        public Usuario ObterUsuario(string nome)
        {
            return _db.Query<Usuario>("SELECT Id,Nome,PerguntaSecreta,RespostaSecreta,Email,Senha FROM tb_usuarios WHERE Nome =@Nome", new { Nome = nome }).SingleOrDefault();
        }

        public string ObterNomeUsuario(string email, string senha)
        {
            var usuario = _db.Query<Usuario>("SELECT Nome FROM tb_usuarios WHERE Email =@Email AND Senha =  @Senha", new { Email = email, Senha = senha }).SingleOrDefault();
            return usuario.Nome;
        }

        public string InserirUsuario(Usuario usuario)
        {
            int linhasAlteradas = this._db.Execute(
                @"INSERT INTO tb_usuarios(Id,Nome,PerguntaSecreta,RespostaSecreta,Email,Senha,StatusUsuario) values (@Id, @Nome, @PerguntaSecreta, @RespostaSecreta, @Email, @Senha, @StatusUsuario)",
                new { Id = usuario.Id, Nome = usuario.Nome, PerguntaSecreta = usuario.PerguntaSecreta, RespostaSecreta = usuario.RespostaSecreta, Email = usuario.Email, Senha = usuario.Senha, StatusUsuario = usuario.StatusUsuario});

            if (linhasAlteradas > 0)
            {
                return "Usuario cadastrado com sucesso!";
            }

            return "Erro ao cadastrar usuário!";
        }

        public string AtualizarUsuario(Usuario usuario)
        {
            int linhasAlteradas = this._db.Execute(
                "UPDATE tb_usuarios SET Nome = @Nome, PerguntaSecreta =  @PerguntaSecreta, RespostaSecreta = @RespostaSecreta, Email = @Email, Senha = @Senha WHERE Id = @Id",
                new { Id= usuario.Id, Nome = usuario.Nome, PerguntaSecreta = usuario.PerguntaSecreta, RespostaSecreta = usuario.RespostaSecreta, Email = usuario.Email, Senha = usuario.Senha});

            if (linhasAlteradas > 0)
            {
                return "Usuario atualizado com sucesso!";
            }

            return "Erro ao atualizar usuário!";
        }

        public string DeletarUsuario(Guid id, string email, string senha)
        {
            int linhasAlteradas = this._db.Execute(
                "UPDATE tb_usuarios SET StatusUsuario = @StatusUsuario WHERE Id = @Id AND Email = @Email AND Senha = @Senha",
                new { Id = id, Email = email, Senha = senha, StatusUsuario = "Desativado" });

            if (linhasAlteradas > 0)
            {
                return "Usuario removido com sucesso!";
            }

            return "Erro ao remover usuário!";
        }
    }
}