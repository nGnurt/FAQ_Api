using FAQ_Api.Data.EF;
using FAQ_Api.Data.Entities;
using FAQ_Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Serivices
{
    public class im_FaqService : Iim_FaqService
    {
        private readonly FaqDbContext _context;       
        public im_FaqService(FaqDbContext context)
        {
            _context = context;            
        }       
        public async Task<int> Create(im_FaqCreateRequest request)
        {           
            var faq = new im_Faq()
                {
                    Id = Guid.NewGuid(),
                    Question = request.Question,
                    Answer = request.Answer,
                    Language = "en",
                    CreatedDate = DateTime.Now
                };
             _context.im_Faqs.Add(faq);

            var Tran1 = new im_Faq_Translation()
                {
                    Id = Guid.NewGuid(),
                    FaqId = faq.Id,
                    Question = request.Question,
                    Answer = request.Answer,
                    Language = "cn",
                    CreatedDate = DateTime.Now
                };
            _context.im_Faq_Translations.Add(Tran1);

            var Tran2 = new im_Faq_Translation()
                {
                    Id = Guid.NewGuid(),
                    FaqId = faq.Id,
                    Question = request.Question,
                    Answer = request.Answer,
                    Language = "jp",
                    CreatedDate = DateTime.Now
                };
            _context.im_Faq_Translations.Add(Tran2);

            var Tran3 = new im_Faq_Translation()
                {
                    Id = Guid.NewGuid(),
                    FaqId = faq.Id,
                    Question = request.Question,
                    Answer = request.Answer,
                    Language = "vi",
                    CreatedDate = DateTime.Now
                };
            _context.im_Faq_Translations.Add(Tran3);
            return await _context.SaveChangesAsync();
                
        }       
        public Task<int> Get(im_FaqCreateRequest request)
        {
            throw new NotImplementedException();
        }
       

        public async Task<int> Update(im_FaqUpdateRequest request)
        {
            var faq = await _context.im_Faqs.FindAsync(request.Id);
            if (faq == null) throw new Exception("Cannot find the department");
            //if(request.Id == FaqId)
            faq.Question = request.Question;
            faq.Answer = request.Answer;
            faq.ModifiedDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }
    }
}
