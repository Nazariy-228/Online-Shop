using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.DataConfiguration
{
    public class IncidentsConfiguration : IEntityTypeConfiguration<Incidents>
    {
        public void Configure(EntityTypeBuilder<Incidents> builder)
        {
            builder.ToTable("Incidents");

            builder.HasKey(incident => incident.Name);
            builder.Property(incident => incident.Name).HasDefaultValueSql("NEWID()");
        }
    }
}