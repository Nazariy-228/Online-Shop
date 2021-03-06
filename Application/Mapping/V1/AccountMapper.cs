using Application.Dto.V1;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.V1
{
    class AccountMapping : Profile
    {
        public AccountMapping()
        {
            CreateMap<AccountDto, Accounts>().ReverseMap();
            CreateMap<AccountDto, ContactDto>().ReverseMap();
        }
    }
}