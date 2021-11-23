using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Models;
using Application.Repository;
using Application.Services;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class CaseService : ICaseService
    {
        private readonly IIncidentService _incidentService;
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CaseService(
            IMapper mapper,
            IIncidentService incidentService,
            IAccountService accountService)
        {
            _mapper = mapper;
            _incidentService = incidentService;
            _accountService = accountService;
        }
        
        public async Task<CaseDto> AddCaseAsync(CaseDto caseDto)
        {
            var incident = await _incidentService.AddIncidentAsync(_mapper.Map<IncidentDto>(caseDto));
            var account = await _accountService.AddAccountAsync(_mapper.Map<AccountDto>(caseDto));

            return new CaseDto();
        }
    }
}