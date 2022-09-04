using Microsoft.AspNetCore.Mvc;
using Ocorrencia_API.Domain.DTO;
using Ocorrencia_API.Domain.Interfaces;
using Ocorrencia_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ocorrencia_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OcorrenciaController : ControllerBase
    {
        private readonly IOcorrenciaRepository _ocorrenciaRepository;

        public OcorrenciaController(IOcorrenciaRepository ocorrenciaRepository)
        {
            _ocorrenciaRepository = ocorrenciaRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Ocorrencia>> GetOcorrencia()
        {
            return await _ocorrenciaRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ocorrencia>> GetOneOcorrencia(int id)
        {
            return await _ocorrenciaRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Ocorrencia>> PostOcorrencia([FromBody] Ocorrencia ocorrencia)
        {
            var data = await _ocorrenciaRepository.Create(ocorrencia);

            return CreatedAtAction(nameof(GetOcorrencia), new { id = data.IdOcorrencia }, data);
        }

        [HttpPut]
        public async Task<ActionResult> PutPedido(int id, [FromBody] Ocorrencia ocorrencia)
        {
            if (id != ocorrencia.IdOcorrencia)
            {
                return BadRequest();
            }
            else
            {
                await _ocorrenciaRepository.Update(ocorrencia);
                return NoContent();
            }
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePedido(int id)
        {
            var data = await _ocorrenciaRepository.Get(id);

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                await _ocorrenciaRepository.Delete(data.IdOcorrencia);
                return NoContent();
            }
        }
    }
}
