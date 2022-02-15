using FAQ_Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Data.Configuration
{
    public class im_Faq_TranslationConfiguration : IEntityTypeConfiguration<im_Faq_Translation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<im_Faq_Translation> builder)
        {
            builder.ToTable("im_Faq_Translation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Language).HasMaxLength(5).IsRequired();
            builder.Property(x => x.Question).IsRequired();
            builder.Property(x => x.Answer).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.HasOne(x => x.im_Faq).WithMany(x => x.im_Faq_Translation).HasForeignKey(x => x.FaqId);
        }
    }
}
