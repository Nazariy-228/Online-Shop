using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.DataConfiguration
{
    sealed class AccountsConfiguration : IEntityTypeConfiguration<Accounts>
    {
        public void Configure(EntityTypeBuilder<Accounts> builder)
        {
            builder.ToTable("Accounts");

            builder.HasKey(account => account.Id);
            builder.HasIndex(account => account.Name).IsUnique();

            builder.HasOne(p => p.Incident).WithMany(i => i!.Accounts);
        }
    }
}