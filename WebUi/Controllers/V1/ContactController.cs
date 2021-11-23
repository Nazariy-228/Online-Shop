using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using WebUi.Templates.V1;

namespace WebUi.Controllers.V1
{
    [Route(ApiRoutes.Contact.Contacts)]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddContact([FromBody] ContactDto contact)
        {
            return Ok(await _contactService.AddContactAsync(contact));
        }
    }
}