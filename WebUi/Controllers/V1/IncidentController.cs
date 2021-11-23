using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using WebUi.Templates.V1;

namespace WebUi.Controllers.V1
{
    [Route(ApiRoutes.Incident.Incidents)]
    [ApiController]
    public class IncidentController : Controller
    {
        private readonly IIncidentService _incidentService;

        public IncidentController(IIncidentService incidentService)
        {
            _incidentService = incidentService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddContact([FromBody] IncidentDto incident)
        {
            return Ok(await _incidentService.AddIncidentAsync(incident));
        }
    }
}