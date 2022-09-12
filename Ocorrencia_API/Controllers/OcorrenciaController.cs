using AutoMapper;
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
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public OcorrenciaController(IOcorrenciaRepository ocorrenciaRepository, IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _ocorrenciaRepository = ocorrenciaRepository;
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<OcorrenciaDTO>> GetOcorrencia()
        {
            var ocorrencia = await _ocorrenciaRepository.Get();

            var ocorrenciaDTO = _mapper.Map<List<OcorrenciaDTO>>(ocorrencia);

            return ocorrenciaDTO;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OcorrenciaDTO>> GetOneOcorrencia(int id)
        {
            var ocorrencia = await _ocorrenciaRepository.Get(id);

            if (ocorrencia != null)
            {
                var ocorrenciaDTO = _mapper.Map<OcorrenciaDTO>(ocorrencia);

                return ocorrenciaDTO;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Ocorrencia>> PostOcorrencia([FromBody] OcorrenciaDTO ocorrenciaDTO)
        {
            var ocorrencia = _mapper.Map<Ocorrencia>(ocorrenciaDTO);

            var data = await _ocorrenciaRepository.Create(ocorrencia);

            if (data != null)
            {
                return CreatedAtAction(nameof(GetOcorrencia), new { id = data.IdOcorrencia }, data);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> PutOcorrencia(int id, [FromBody] OcorrenciaDTO ocorrenciaDTO)
        {
            if (id != ocorrenciaDTO.IdOcorrencia)
            {
                return BadRequest();
            }

            var ocorrencia = _mapper.Map<Ocorrencia>(ocorrenciaDTO);

            await _ocorrenciaRepository.Update(ocorrencia);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOcorrencia(int id)
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
