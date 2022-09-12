using Microsoft.EntityFrameworkCore;
using Ocorrencia_API.Data.Context;
using Ocorrencia_API.Domain.Interfaces;
using Ocorrencia_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ocorrencia_API.Data.Repositories
{
    public class OcorrenciaRepository : IOcorrenciaRepository
    {
        public readonly AppDbContext _context;

        public OcorrenciaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Ocorrencia>> Get()
        {
            return await _context.Ocorrencia.ToListAsync();
        }

        public async Task<Ocorrencia> Get(int id)
        {
            return await _context.Ocorrencia.FindAsync(id);
        }

        public async Task<Ocorrencia> Create(Ocorrencia ocorrencia)
        {
            var idValid = await _context.Pedido.FirstOrDefaultAsync(i => i.IdPedido == ocorrencia.PedidoId);

            if (idValid != null)
            {
                _context.Ocorrencia.Add(ocorrencia);

                await _context.SaveChangesAsync();

                return ocorrencia;
            }
            else
            {
                return null;
            }
        }

        public async Task Update(Ocorrencia ocorrencia)
        {
            _context.Entry(ocorrencia).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var data = await _context.Ocorrencia.FindAsync(id);

            _context.Ocorrencia.Remove(data);

            await _context.SaveChangesAsync();
        }
    }
}
