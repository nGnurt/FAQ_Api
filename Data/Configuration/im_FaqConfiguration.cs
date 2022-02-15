using FAQ_Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FAQ_Api.Data.Configuration
{
    public class im_FaqConfiguration : IEntityTypeConfiguration<im_Faq_Translation>
    {
        public void Configure(EntityTypeBuilder<im_Faq_Translation> builder)
        {
            builder.ToTable("im_Faq");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Language).HasMaxLength(5).IsRequired();
            builder.Property(x => x.Question).IsRequired();
            builder.Property(x => x.Answer).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
        }
    }
}
