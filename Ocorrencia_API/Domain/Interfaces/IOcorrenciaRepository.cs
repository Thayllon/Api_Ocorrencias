using Ocorrencia_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocorrencia_API.Domain.Interfaces
{
    public interface IOcorrenciaRepository
    {
        Task<IEnumerable<Ocorrencia>> Get();

        Task<Ocorrencia> Get(int id);

        Task<Ocorrencia> Create(Ocorrencia ocorrencia);

        Task Update(Ocorrencia ocorrencia);

        Task Delete(int id);
    }
}
