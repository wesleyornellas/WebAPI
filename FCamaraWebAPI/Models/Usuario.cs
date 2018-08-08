using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FCamaraWebAPI.Enum;

namespace FCamaraWebAPI.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Enum_PerguntaSecreta PerguntaSecreta { get; set; }
        public string RespostaSecreta { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool StatusUsuario { get; set; }
    }
}