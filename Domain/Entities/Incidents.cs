using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public sealed class Incidents : IEntity
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Accounts>? Accounts { get; set; }
    }
}