using FAQ_Api.Data.Configuration;
using FAQ_Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Data.EF
{
    public class FaqDbContext : DbContext
    {
        public FaqDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new im_FaqConfiguration());
            modelBuilder.ApplyConfiguration(new im_Faq_TranslationConfiguration());
        }
        public DbSet<im_Faq> im_Faqs { get; set; }
        public DbSet<im_Faq_Translation> im_Faq_Translations { get; set; }
    }
}
