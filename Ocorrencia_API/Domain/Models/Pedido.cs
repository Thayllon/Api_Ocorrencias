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
        [Key]
        public int IdPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int NumeroPedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
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
        public List<Ocorrencia> Ocorrencia { get; set; }
    }
}
