using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.DataConfiguration
{
    sealed class ContactsConfiguration : IEntityTypeConfiguration<Contacts>
    {
        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder.ToTable("Contacts");

            builder.HasKey(contact => contact.Id);

            builder.HasOne(p => p.Account).WithMany(a => a!.Contacts);
        }
    }
}