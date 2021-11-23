using System.Threading.Tasks;
using Application.Dto.V1;
using Application.Services;
using Microsoft.AspNetCore.Mvc;
using WebUi.Templates.V1;

namespace WebUi.Controllers.V1
{
    [Route(ApiRoutes.Account.Accounts)]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddAccount([FromBody] AccountDto account)
        {
            return Ok(await _accountService.AddAccountAsync(account));
        }
    }
}