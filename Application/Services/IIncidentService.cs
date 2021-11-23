using System.Threading.Tasks;
using Application.Dto.V1;
using Domain.Entities;

namespace Application.Services
{
    public interface IIncidentService
    {
        Task<Incidents> AddIncidentAsync(IncidentDto incidentDto);
    }
}