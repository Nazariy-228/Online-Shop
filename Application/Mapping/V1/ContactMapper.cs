using Application.Dto.V1;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.V1
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<ContactDto, Contacts>().ReverseMap();
        }
    }
}