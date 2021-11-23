using System;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Domain.Entities
{
    public sealed class Contacts : IEntity
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }
        
        public Accounts? Account { get; set; }
    }
}