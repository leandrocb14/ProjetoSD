﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSD.WebAPI.BLL
{
    public abstract class ValidacaoBLL
    {

        /// <summary>
        /// Valida <paramref name="valorParametro"/> se é nulo ou vazio.
        /// </summary>
        /// <exception cref="ArgumentException">Exception lançada quando o parâmetro <paramref name="valorParametro"/> for nulo ou vazio.</exception>
        /// <param name="valorParametro">Representa o valor do parâmetro.</param>
        /// <param name="nomeParametro">Representa o nome do parâmetro.</param>
        public void ValidaParametroEmBrancoOuVazio(string valorParametro, string nomeParametro)
        {
            if (string.IsNullOrEmpty(valorParametro))
            {
                throw new ArgumentException(string.Format($"O parâmetro {nomeParametro} é de preenchimento obrigatório"));
            }
        }
    }
}