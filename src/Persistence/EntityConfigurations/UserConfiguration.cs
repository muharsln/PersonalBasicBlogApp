using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Username)
               .IsRequired()
               .HasMaxLength(25);

        builder.Property(e => e.Email)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(e => e.Password)
               .IsRequired()
               .HasMaxLength(100);

        builder.HasMany(e => e.Posts)
               .WithOne(p => p.User)
               .HasForeignKey(p => p.UserId);

        builder.HasMany(e => e.Comments)
               .WithOne(c => c.User)
               .HasForeignKey(c => c.UserId);
    }
}