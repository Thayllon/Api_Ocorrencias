using Microsoft.AspNetCore.Mvc;
using Ocorrencia_API.Domain.Interfaces;
using Ocorrencia_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ocorrencia_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Pedido>> GetPedido()
        {
            return await _pedidoRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetOnePedido(int id)
        {
            return await _pedidoRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Pedido>> PostPedido([FromBody] Pedido pedido)
        {
            var data = await _pedidoRepository.Create(pedido);

            return CreatedAtAction(nameof(GetPedido), new { id = data.IdPedido }, data);
        }

        [HttpPut]
        public async Task<ActionResult> PutPedido(int id, [FromBody] Pedido pedido)
        {
            if (id != pedido.IdPedido)
            {
                return BadRequest();
            }
            else
            {
                await _pedidoRepository.Update(pedido);
                return NoContent();
            }       
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
