using Application.Dto.V1;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping.V1
{
    class IncidentMapper : Profile
    {
        public IncidentMapper()
        {
            CreateMap<Incidents, IncidentsDto>().ReverseMap();
        }
    }
}