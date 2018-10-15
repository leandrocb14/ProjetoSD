using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoStatus TipoStatus { get; set; }

    }
    
    public enum TipoStatus
    {
        N, S
    }
}