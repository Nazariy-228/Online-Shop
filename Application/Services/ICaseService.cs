using System.Threading.Tasks;
using Application.Dto.V1;

namespace Application.Services
{
    public interface ICaseService
    {
        Task<CaseDto> AddCaseAsync(CaseDto caseDto);
    }
}