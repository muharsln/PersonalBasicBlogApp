using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.User)
               .WithMany(u => u.Posts)
               .HasForeignKey(e => e.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.Title)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Content)
               .IsRequired();

        builder.Property(e => e.CreatedDate)
               .IsRequired();

        builder.HasMany(e => e.Comments)
               .WithOne(c => c.Post)
               .HasForeignKey(c => c.PostId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Categories)
               .WithMany(c => c.Posts);
    }
}