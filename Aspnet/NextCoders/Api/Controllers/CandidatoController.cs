using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private static List<Candidato> DbCandidato = new List<Candidato>();

        // api/candidato
        //actionresult diz o status 
        [HttpPost]
        public ActionResult<Candidato> Cadastrar([FromBody] Candidato candidato)
        {
            // Gerar uma nova ID.
            candidato.Id = Guid.NewGuid();
            // Adicionar o candidato cadastrado.
            DbCandidato.Add(candidato);

            //Retornamos o candidato que foi cadastrado.
            return CreatedAtAction(
                nameof(ObterPorId),
                new { id = candidato.Id},
                "Cadastro realizado."
            );
        }

        // api/candidato
        [HttpGet]
        public ActionResult<IEnumerable<Candidato>> ObterTodos()
        {
            return Ok(DbCandidato);
        }

        // api/candidato
        // Por id sem tratamento
        [HttpGet("{id}")]
        public ActionResult<Candidato> ObterPorId(Guid id)
        {
            Candidato? candidato = DbCandidato.FirstOrDefault(c => c.Id == id);

            return Ok(candidato);
        }

        [HttpPut("{id}")]
        public ActionResult<string> AtualizarPorId(Guid id, [FromBody] Candidato candidatoComDadosAtualizados)
        {
            Candidato? candidato = DbCandidato.FirstOrDefault(c => c.Id == id);
            candidato = candidatoComDadosAtualizados;

            if(candidato != null)
            {
                return Ok("Candidato Atualizado");
            }
            else
            {
                return NotFound("Candidato não foi encontrado");
            }

        }

        [HttpDelete("{id}")]
        public ActionResult<string> AtualizarPorId(Guid id)
        {
            Candidato? candidato = DbCandidato.FirstOrDefault(c => c.Id == id);

            if(candidato != null)
            {
                DbCandidato.Remove(candidato);
                return NoContent();
            } else
            {
                return NotFound("Candidato não encontrado");
            }
        }

    }
}
