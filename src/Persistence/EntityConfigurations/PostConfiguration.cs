using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Title)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(e => e.Content)
               .IsRequired();

        builder.Property(e => e.CreatedDate)
               .IsRequired();

        builder.HasOne(e => e.User)
               .WithMany(u => u.Posts)
               .HasForeignKey(e => e.UserId);

        builder.HasMany(e => e.Comments)
               .WithOne(c => c.Post)
               .HasForeignKey(c => c.PostId);

        builder.HasMany(p => p.PostCategories)
            .WithOne(pc => pc.Post)
            .HasForeignKey(pc => pc.PostId);

    }
}