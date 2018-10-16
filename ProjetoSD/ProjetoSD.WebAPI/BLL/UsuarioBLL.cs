using ProjetoSD.WebAPI.DAO;
using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.BLL
{
    public class UsuarioBLL
    {

        private UsuarioDAO UsuarioDAO;

        public UsuarioBLL()
        {
            this.UsuarioDAO = new UsuarioDAO();
        }

        public Usuario BuscaUsuario(int? id)
        {
            Usuario Usuario = this.UsuarioDAO.BuscaUsuario(id);
            return Usuario;
        }

        public Usuario BuscaUsuario(string email, string senha)
        {
            Usuario Usuario = this.UsuarioDAO.BuscaUsuario(email, senha);
            return Usuario;
        }

        public void AtualizaSenhaUsuario(int? id, string senha, string novaSenha)
        {
            this.UsuarioDAO.AtualizaSenhaUsuario(id, senha, novaSenha);
        }
    }
}