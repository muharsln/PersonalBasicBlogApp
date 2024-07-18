using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
{
    public void Configure(EntityTypeBuilder<PostCategory> builder)
    {
        builder.HasKey(pc => pc.Id);

        builder.HasOne(pc => pc.Post)
            .WithMany(p => p.PostCategories)
            .HasForeignKey(pc => pc.PostId);

        builder.HasOne(pc => pc.Category)
            .WithMany(c => c.PostCategories)
            .HasForeignKey(pc => pc.CategoryId);
    }
}