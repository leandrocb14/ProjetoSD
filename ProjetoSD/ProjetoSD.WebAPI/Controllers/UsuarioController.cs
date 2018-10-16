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

        private UsuarioBLL UsuarioBLL;

        public UsuarioController()
        {
            this.UsuarioBLL = new UsuarioBLL();
        }

        [HttpGet]
        public HttpResponseMessage GetUsuario(int id = 0)
        {
            try
            {
                Usuario Usuario = this.UsuarioBLL.BuscaUsuario(id);
                return Request.CreateResponse(HttpStatusCode.OK, Usuario);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpGet]
        public HttpResponseMessage GetESUsuario(string email = "", string senha = "")
        {
            try
            {
                Usuario Usuario = this.UsuarioBLL.BuscaUsuario(email, senha);
                return Request.CreateResponse(HttpStatusCode.OK, Usuario);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpPut]
        public HttpResponseMessage PutUsuario(int? id = 0, string senha = "", string novaSenha = "")
        {
            try
            {
                this.UsuarioBLL.AtualizaSenhaUsuario(id, senha, novaSenha);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
