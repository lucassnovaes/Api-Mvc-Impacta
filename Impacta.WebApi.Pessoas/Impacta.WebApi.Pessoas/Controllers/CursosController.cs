using Impacta.WebApi.Pessoas.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Impacta.WebApi.Pessoas.Controllers
{
	public class CursosController : ApiController
    {
		//API criada durante o curso de ASP.NET impacta
		//Nivel de complexidade: Baixo

		//Foi criada para o entendimento inicial de chamadas e criação de metodos
		//Chamadas via PostMan

		static List<Curso> cursos = new List<Curso>();
		public CursosController()
		{

		}
		public List<Curso> GetCursos()
		{
			return cursos;
		}
		public Curso GetCurso(int id)
		{
			return cursos.Where(c => c.Id == id).FirstOrDefault();
		}
		public void Post(Curso curso)
		{
			if(curso != null)
			{
				cursos.Add(curso);
			}

		}
		public void PutCurso(Curso curso)
		{
			if (true)
			{
				var result = cursos.Where(c => c.Id == curso.Id).FirstOrDefault();
				result.Nome = curso.Nome;
				result.CargaHoraria = curso.CargaHoraria;

				int posicao = cursos.IndexOf(result);
				cursos.RemoveAt(posicao);
				cursos.Insert(posicao, result);

			}
		}
		public List<Curso> DeleteCursos(int id)
		{
			if(id > 0)
			{
				cursos.RemoveAt(
					cursos.IndexOf(cursos.Where(x => x.Id == id).FirstOrDefault())
					);
	
			}
			return cursos;
		}
    }
}
