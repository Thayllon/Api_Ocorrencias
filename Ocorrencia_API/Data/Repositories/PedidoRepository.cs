using Microsoft.EntityFrameworkCore;
using Ocorrencia_API.Data.Context;
using Ocorrencia_API.Domain.Interfaces;
using Ocorrencia_API.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocorrencia_API.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Pedido>> Get()
        {
            return await _context.Pedido.Include(x => x.Ocorrencia).ToListAsync();
            //return await _context.Pedido.ToListAsync();
        }

        public async Task<Pedido> Get(int id)
        {
            return await _context.Pedido.FindAsync(id);
        }

        public async Task<Pedido> Create(Pedido pedido)
        {
            _context.Pedido.Add(pedido);

            await _context.SaveChangesAsync();

            return pedido;
        }

        public async Task Update(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var data = await _context.Pedido.FindAsync(id);

            _context.Pedido.Remove(data);

            await _context.SaveChangesAsync();
        }
    }
}
