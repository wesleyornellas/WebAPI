using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FCamaraWebAPI.DAL;
using FCamaraWebAPI.Models;

namespace FCamaraWebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        private UsuarioRepository repositorio;

        public UsuarioController()
        {
            repositorio = new UsuarioRepository();
        }

        // GET: api/Usuario/Nome
        [Route("api/usuario/{nome}")]
        [HttpGet]
        public Usuario Get(string nome)
        {
            return repositorio.ObterUsuario(nome);
        }

        // GET: api/Usuario/Email/Senha
        [Route("api/usuario/{email}/{senha}")]
        [HttpGet]
        public string Get(string email, string senha)
        {
            return repositorio.ObterNomeUsuario(email, senha);
        }

        // POST: api/Usuario
        [Route("api/usuario")]
        [HttpPost]
        public string Post([FromBody]Usuario usuario)
        {
            return repositorio.InserirUsuario(usuario);
        }

        // PUT: api/Usuario/5
        [Route("api/usuario")]
        [HttpPut]
        public string Put([FromBody]Usuario usuario)
        {
            return repositorio.AtualizarUsuario(usuario);
        }

        // DELETE: api/Usuario/5
        [Route("api/usuario/{id}/{email}/{senha}")]
        [HttpDelete]
        public string Delete(Guid id, string email, string senha)
        {
            return repositorio.DeletarUsuario(id, email, senha);
        }
    }
}
