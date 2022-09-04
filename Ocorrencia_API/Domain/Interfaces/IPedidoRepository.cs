using Ocorrencia_API.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ocorrencia_API.Domain.Interfaces
{
    public interface IPedidoRepository
    {
        Task<IEnumerable<Pedido>> Get();
        
        Task<Pedido> Get(int id);

        Task<Pedido> Create(Pedido pedido); 
        
        Task Update(Pedido pedido); 
        
        Task Delete(int id);
    }
}
