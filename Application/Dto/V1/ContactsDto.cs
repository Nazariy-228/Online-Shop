using System;

namespace Application.Dto.V1
{
    public class ContactsDto
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }
        
    }
}