using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Accounts : IEntity
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }

        public Incidents? Incident { get; set; }

        public ICollection<Contacts>? Contacts { get; set; }
    }
}