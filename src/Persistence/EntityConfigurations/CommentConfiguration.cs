using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.User)
               .WithMany(u => u.Comments)
               .HasForeignKey(e => e.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(e => e.Post)
               .WithMany(p => p.Comments)
               .HasForeignKey(e => e.PostId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.Property(e => e.Text)
               .IsRequired()
               .HasMaxLength(500);
    }
}