using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FCamaraWebAPI.Models;
using FCamaraWebAPI.DAL;

namespace FCamaraWebAPI.Tests
{
    [TestClass]
    public class UsuarioTest
    {

        [TestMethod]
        public void ObterUsuarios()
        {
            var usuarios = ListaUsuariosTest();
        }

        private List<Usuario> ListaUsuariosTest()
        {
            var usuariosTeste = new List<Usuario>();
            usuariosTeste.Add(new Usuario { Id = new Guid(), Nome = "Adriely", PerguntaSecreta = Enum.Enum_PerguntaSecreta.Em_que_cidade_você_nasceu, RespostaSecreta = "Rio de Janeiro", Email = "adriely@outlook.com", Senha = "!Jklmn2" });
            usuariosTeste.Add(new Usuario { Id = new Guid(), Nome = "Luis", PerguntaSecreta = Enum.Enum_PerguntaSecreta.Qual_é_a_sua_comida_favorita, RespostaSecreta = "Lasanha", Email = "luis@outlook.com", Senha = "$uiop" });

            return usuariosTeste;
        }
    }
}
