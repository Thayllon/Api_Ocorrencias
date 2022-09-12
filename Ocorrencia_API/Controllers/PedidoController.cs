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
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IMapper _mapper;

        public PedidoController(IPedidoRepository pedidoRepository, IMapper mapper)
        {
            _pedidoRepository = pedidoRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Pedido>> GetPedido()
        {
            return await _pedidoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PedidoDTO>> GetOnePedido(int id)
        {
            var pedido = await _pedidoRepository.Get(id);

            if (pedido != null)
            {
                var pedidoDTO = _mapper.Map<PedidoDTO>(pedido);

                return pedidoDTO;
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido([FromBody] PedidoDTO pedidoDTO)
        {
            var ocorrencia = _mapper.Map<Pedido>(pedidoDTO);

            var data = await _pedidoRepository.Create(ocorrencia);

            return CreatedAtAction(nameof(GetPedido), new { id = data.IdPedido }, data);
        }

        [HttpPut]
        public async Task<ActionResult> PutPedido(int id, [FromBody] PedidoDTO pedidoDTO)
        {
            if (id != pedidoDTO.IdPedido)
            {
                return BadRequest();
            }

            var pedido = _mapper.Map<Pedido>(pedidoDTO);

            await _pedidoRepository.Update(pedido);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePedido(int id)
        {
            var data = await _pedidoRepository.Get(id);

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                await _pedidoRepository.Delete(data.IdPedido);
                return NoContent();
            }
        }
    }
}
