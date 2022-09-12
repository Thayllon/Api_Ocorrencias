using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ocorrencia_API.Domain.Models
{
    public class Pedido
    {
        /// <summary>
        ///     
        /// </summary>
        public int IdPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int NumeroPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime HoraPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IndCancelado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IndConcluido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Ocorrencia> Ocorrencias { get; set; }
    }
}
