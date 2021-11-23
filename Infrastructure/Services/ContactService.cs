using System.Linq;
using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Repository;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contacts> _contactRepository;
        private readonly IMapper _mapper;
        
        public ContactService(
            IRepository<Contacts> contactRepository, 
            IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }
        
        public async Task<Contacts> AddContactAsync(ContactDto contactDto)
        {
            var contact = await _contactRepository
                .Query()
                .FirstOrDefaultAsync(c => c.Email == contactDto.Email);

            if (contact is null)
                return await _contactRepository.AddAsync(_mapper.Map<Contacts>(contactDto));
            
            return await _contactRepository.UpdateAsync(_mapper.Map<Contacts>(contactDto));
        }
    }
}