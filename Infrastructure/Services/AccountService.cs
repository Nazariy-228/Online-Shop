using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Repository;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<Accounts> _accountRepository;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public AccountService(
            IRepository<Accounts> accountRepository,
            IContactService contactService, 
            IMapper mapper)
        {
            _accountRepository = accountRepository;
            _contactService = contactService;
            _mapper = mapper;
        }
        
        public async Task<Accounts> AddAccountAsync(AccountDto accountDto)
        {
            var account = await _accountRepository
                .Query()
                .FirstOrDefaultAsync(a => a.Id == accountDto.Id);

            if (account is null)
            {
                await _contactService.AddContactAsync(_mapper.Map<ContactDto>(accountDto));

                
            }

            return await _accountRepository.UpdateAsync(_mapper.Map<Accounts>(accountDto));
        }
    }
}