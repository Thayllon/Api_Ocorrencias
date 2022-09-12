using AutoMapper;
using Ocorrencia_API.Domain.Models;

namespace Ocorrencia_API.Domain.DTO.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pedido, PedidoDTO>().ReverseMap();
            CreateMap<Ocorrencia, OcorrenciaDTO>().ReverseMap();
        }
    }
}
