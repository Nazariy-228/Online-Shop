using System.Threading.Tasks;
using Application.Dto.V1;
using Domain.Entities;

namespace Application.Services
{
    public interface IContactService
    {
        Task<Contacts> AddContactAsync(ContactDto contact);
    }
}