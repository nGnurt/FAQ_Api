using FAQ_Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ_Api.Serivices
{
    public interface Iim_FaqService
    {
        Task<int> Create(im_FaqCreateRequest request);
        Task<int> Update(im_FaqUpdateRequest request);
        Task<int> Get(im_FaqCreateRequest request);
    }
}
