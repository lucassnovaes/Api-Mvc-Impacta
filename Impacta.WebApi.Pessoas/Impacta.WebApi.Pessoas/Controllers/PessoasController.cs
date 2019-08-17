using Impacta.WebApi.Pessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Impacta.WebApi.Pessoas.Controllers
{
    public class PessoasController : ApiController
    {
		#region Breve descricao
		//API criada durante o curso de ASP.NET impacta
		//Nivel de complexidade: Baixo

		//Foi criada para o entendimento inicial de chamadas e criação de metodos
		//Chamadas via PostMan
		#endregion
		#region Chamadas
		//GET
		//http:/<localhost>/api/pessoas

		//POST
		//http:/<localhost>/api/pessoas
		//    {
		//		"Nome": "Lucas"
		//	}
		#endregion

		//Lista para simular dados
		static List<Pessoa> pessoas = new List<Pessoa>();

		public PessoasController()
		{

		}

		public List<Pessoa> Get()
		{
			return pessoas;
		}
		
		public void Post(string nomeDaPessoa)
		{
			if (!string.IsNullOrWhiteSpace(nomeDaPessoa))
			{
				pessoas.Add(new Pessoa { Nome = nomeDaPessoa });
			}

		}

		public void Post(Pessoa pessoa)
		{
			if (pessoa != null)
			{
				pessoas.Add(pessoa);
			}
		}
    }
}
