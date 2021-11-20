using Application.Dto.V1;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.V1
{
    class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<Contacts, ContactsDto>().ReverseMap();
        }
    }
}