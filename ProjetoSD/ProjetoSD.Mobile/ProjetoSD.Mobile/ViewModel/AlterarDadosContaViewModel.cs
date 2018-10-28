using ProjetoSD.Mobile.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoSD.Mobile.ViewModel
{
    public class AlterarDadosUsuarioViewModel
    {

        private UFBLL UFBLL { get; set; }

        public List<string> ListarUFs { get { return this.UFBLL.ListarUFs(); } }

        public AlterarDadosUsuarioViewModel()
        {
            this.UFBLL = new UFBLL();
        }
    }
}
