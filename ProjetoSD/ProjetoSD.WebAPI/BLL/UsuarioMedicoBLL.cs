using ProjetoSD.WebAPI.DAO;
using ProjetoSD.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.BLL
{
    public class UsuarioMedicoBLL
    {

        private UsuarioMedicoDAO UsuarioDAO;

        public UsuarioMedicoBLL()
        {
            this.UsuarioDAO = new UsuarioMedicoDAO();
        }

        /// <summary>
        /// Usado para verificar o login do usuário
        /// </summary>
        /// <param name="email">Representa o email do usuário.</param>
        /// <param name="senha">Representa a senha do usuário.</param>
        /// <returns>Retorna o restante das informações desse usuário</returns>
        public Medico BuscaUsuarioMedico(string email, string senha)
        {
            ValidaParametroEmBrancoOuVazio(email, "email");
            ValidaParametroEmBrancoOuVazio(senha, "senha");
            Medico Medico = this.UsuarioDAO.BuscaUsuarioMedico(email, senha);
            return Medico;
        }

        /// <summary>
        /// Usado para cadastrar um novo usuário.
        /// </summary>        
        /// <param name="email">Representa o email do usuário.</param>
        /// <param name="senha">Representa a senha do usuário.</param>
        public void CadastraUsuario(string crm, string nome, UF uF, string profissao, string email, string senha)
        {
            ValidaParametroEmBrancoOuVazio(crm, "crm");
            ValidaParametroEmBrancoOuVazio(nome, "nome");
            ValidaParametroEmBrancoOuVazio(Convert.ToString(uF), "UF");
            ValidaParametroEmBrancoOuVazio(profissao, "profissao");
            ValidaParametroEmBrancoOuVazio(email, "email");
            ValidaParametroEmBrancoOuVazio(senha, "senha");
            this.UsuarioDAO.CadastraUsuario(crm, nome, uF, profissao, email, senha);
        }

        /// <summary>
        /// Valida <paramref name="valorParametro"/> se é nulo ou vazio.
        /// </summary>
        /// <exception cref="FormatException">Exception lançada quando o parâmetro <paramref name="valorParametro"/> for nulo ou vazio.</exception>
        /// <param name="valorParametro">Representa o valor do parâmetro.</param>
        /// <param name="nomeParametro">Representa o nome do parâmetro.</param>
        private void ValidaParametroEmBrancoOuVazio(string valorParametro, string nomeParametro)
        {
            if (string.IsNullOrEmpty(valorParametro))
            {
                throw new FormatException(string.Format($"O parâmetro {nomeParametro} é de preenchimento obrigatório"));
            }
        }
    }
}