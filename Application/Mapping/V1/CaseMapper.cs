using Application.Dto.V1;
using Application.Models;
using AutoMapper;

namespace Application.Mapping.V1
{
    public class CaseMapper : Profile
    {
        public CaseMapper()
        {
            CreateMap<CaseDto, AccountDto>().ReverseMap();
            CreateMap<CaseDto, IncidentDto>().ReverseMap();
            CreateMap<CaseDto, CaseModel>().ReverseMap();
        }
    }
}