using AutoMapper;
using GeekShopping.Api.Domain.Dto;
using GeekShopping.Api.Domain.Entities;

namespace GeekShopping.Api.Infra.CrossCutting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {

            CreateMap<ProductDto, Product>().ReverseMap();


        }
    }
}
