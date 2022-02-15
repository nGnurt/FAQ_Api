using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Data.Entities
{
    public class im_Faq_Translation
    {
        public Guid Id { get; set; }
        public Guid FaqId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Language { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public im_Faq im_Faq { get; set; }
    }   
}
