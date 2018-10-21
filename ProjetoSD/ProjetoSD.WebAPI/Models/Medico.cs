using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.Models
{
    public class Medico
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public UF UF { get; set; }
        public string Profissao { get; set; }
    }
}