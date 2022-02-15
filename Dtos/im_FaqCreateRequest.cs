using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Dtos
{
    public class im_FaqCreateRequest
    {
        public Guid Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }        
        public DateTime CreatedDate { get; set; }
        
    }
}
