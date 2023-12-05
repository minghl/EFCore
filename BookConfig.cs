using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("T_Books");
        builder.Property(b => b.Title).HasMaxLength(50).IsRequired();
        builder.Property(b => b.AuthorName).HasMaxLength(20).IsRequired();
    }
}
