using Ocorrencia_API.Domain.Models;
using System;

namespace Ocorrencia_API.Domain.DTO
{
    public class OcorrenciaDTO
    {
  
        public int IdOcorrencia { get; set; }
    
        public string TipoOcorrencia { get; set; }

        public DateTime HoraOcorrencia { get; set; }
      
        public bool IndFinalizadora { get; set; }

        public Pedido Pedido { get; set; }

        public int Idpedido { get; set; }
    }
}
