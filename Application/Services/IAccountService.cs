using System.Threading.Tasks;
using Application.Dto.V1;
using Domain.Entities;

namespace Application.Services
{
    public interface IAccountService
    {
        Task<Accounts> AddAccountAsync(AccountDto accountDto);
    }
}