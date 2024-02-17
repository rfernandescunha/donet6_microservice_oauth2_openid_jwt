using AutoMapper;
using GeekShopping.Api.Domain.Dto;
using GeekShopping.Api.Domain.Entities;

namespace GeekShopping.Api.Infra.CrossCutting.AutoMapper
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
