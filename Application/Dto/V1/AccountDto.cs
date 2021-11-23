using System;

namespace Application.Dto.V1
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }

        public string? ContactFirstName { get; set; }

        public string? ContactLastName { get; set; }

        public string? ContactEmail { get; set; }
    }
}