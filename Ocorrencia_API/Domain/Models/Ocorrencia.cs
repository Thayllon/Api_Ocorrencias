using System;
using System.ComponentModel.DataAnnotations;

namespace Ocorrencia_API.Domain.Models
{
    public class Ocorrencia
    {
        /// <summary>
        ///     
        /// </summary>
        [Key]
        public int IdOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string TipoOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime HoraOcorrencia { get; set; }

        /// <summary>
        /// 
        /// </summary>       
        public bool IndFinalizadora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //public Pedido Pedido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        //public int Idpedido { get; set; }
    }
}
