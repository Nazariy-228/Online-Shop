using System;

namespace Application.Models
{
    public class CaseModel
    {
        public Guid Id { get; set; }
        
        public string? Name { get; set; }

        public string? ContactFirstName { get; set; }

        public string? ContactLastName { get; set; }

        public string? ContactEmail { get; set; }
        
        public string? IncidentDescription { get; set; }
    }
}