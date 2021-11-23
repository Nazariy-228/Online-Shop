using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Repository;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class IncidentService : IIncidentService
    {
        private readonly IRepository<Incidents> _incidentRepository;
        private readonly IMapper _mapper;
        
        public IncidentService(
            IRepository<Incidents> incidentRepository,
            IMapper mapper)
        {
            _incidentRepository = incidentRepository;
            _mapper = mapper;
        }
        
        public async Task<Incidents> AddIncidentAsync(IncidentDto incidentDto)
        {
            var incident = await _incidentRepository
                .Query()
                .FirstOrDefaultAsync(i => i.Name == incidentDto.Name);

            if (incident is null)
            {
                return await _incidentRepository.AddAsync(_mapper.Map<Incidents>(incidentDto));
            }

            return await _incidentRepository.UpdateAsync(_mapper.Map<Incidents>(incidentDto));
        }
    }
}