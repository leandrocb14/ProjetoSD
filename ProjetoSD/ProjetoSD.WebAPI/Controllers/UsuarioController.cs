using ProjetoSD.WebAPI.BLL;
using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoSD.WebAPI.Controllers
{
    public class UsuarioController : ApiController
    {

        private UsuarioMedicoBLL UsuarioBLL;

        public UsuarioController()
        {
            this.UsuarioBLL = new UsuarioMedicoBLL();
        }

        [HttpGet]
        public HttpResponseMessage GetESUsuario(string email = "", string senha = "")
        {
            try
            {
                Medico Medico = this.UsuarioBLL.BuscaUsuarioMedico(email, senha);
                return Request.CreateResponse(HttpStatusCode.OK, Medico);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpPost]
        public HttpResponseMessage PostUsuario(string crm = "", string nome = "", UF uF = UF.AC, string profissao = "", string email = "", string senha = "")
        {
            try
            {
                this.UsuarioBLL.CadastraUsuario(crm, nome, uF, profissao, email, senha);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
