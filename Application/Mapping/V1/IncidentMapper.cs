using Application.Dto.V1;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.V1
{
    public class IncidentMapper : Profile
    {
        public IncidentMapper()
        {
            CreateMap<IncidentDto, Incidents>().ReverseMap();
        }
    }
}