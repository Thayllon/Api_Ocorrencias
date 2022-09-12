using System;
using System.ComponentModel.DataAnnotations;

namespace Ocorrencia_API.Domain.Models
{
    public class Ocorrencia
    {
        /// <summary>
        ///     
        /// </summary>
        public int IdOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TipoOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime HoraOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>       
        public bool IndFinalizadora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Pedido Pedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PedidoId { get; set; }
    }
}
