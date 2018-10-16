using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.DAO
{
    public class UsuarioDAO
    {

        private EntidadeContext EntidadeContext;

        public UsuarioDAO()
        {
            this.EntidadeContext = new EntidadeContext();
        }

        public Usuario BuscaUsuario(int? id)
        {
            var query = from q in EntidadeContext.Usuarios
                        where q.Id.Equals(id)
                        select q;
            Usuario Usuario = query.FirstOrDefault();
            if (Usuario == null)
            {
                throw new NullReferenceException("Não foi encontrado nenhum usuário com esse Id.");
            }
            return query.FirstOrDefault();
        }

        public Usuario BuscaUsuario(string email, string senha)
        {
            var query = from q in EntidadeContext.Usuarios
                        where q.Email.Equals(email) && q.Senha.Equals(senha)
                        select q;
            Usuario Usuario = query.FirstOrDefault();
            if (Usuario == null)
            {
                throw new NullReferenceException("Usuário não encontrado.");
            }
            return query.FirstOrDefault();
        }

        private Usuario BuscaUsuario(int? id, string senha)
        {
            var query = from q in EntidadeContext.Usuarios
                        where q.Id.Equals(id) && q.Senha.Equals(senha)
                        select q;
            Usuario Usuario = query.FirstOrDefault();
            if (Usuario == null)
            {
                throw new NullReferenceException("Usuário não encontrado.");
            }
            return query.FirstOrDefault();
        }

        public void AtualizaSenhaUsuario(int? id, string senha, string novaSenha)
        {
            Usuario Usuario = BuscaUsuario(id, senha);
            if (string.IsNullOrEmpty(senha))
            {
                throw new FormatException("Senha é de preenchimento obrigatório.");
            }
            if (string.IsNullOrEmpty(novaSenha))
            {
                throw new FormatException("A nova senha não pode estar branco ou conter menos que 5 caracteres.");
            }
            Usuario.Senha = novaSenha;
            this.EntidadeContext.SaveChanges();
        }
        
    }
}