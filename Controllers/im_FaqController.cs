using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FAQ_Api.Data.EF;
using FAQ_Api.Data.Entities;
using Microsoft.Extensions.Logging;
using FAQ_Api.Dtos;
using FAQ_Api.Serivices;
using Serilog;

namespace FAQ_Api.Controllers
{
    [ApiController]
    [Route("api/v1/faqs")]
    public class im_FaqController : Controller
    {
        private readonly Iim_FaqService _im_FaqService;
        public im_FaqController(Iim_FaqService im_FaqService)
        {
            _im_FaqService = im_FaqService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(im_FaqCreateRequest request)
        {
            
            try
            {
                var result = await _im_FaqService.Create(request);
                return Ok();
            }
            catch (Exception ex)
            {
               Log.Error(ex, "Create request is not responed.");
                return BadRequest();
            }           
        }
        [HttpPut]
        public async Task<IActionResult> Update(im_FaqUpdateRequest request)
        {
            try
            {
                var result = await _im_FaqService.Update(request);
                return Ok();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Update request is not responed.");
                return BadRequest();
            }
        }
        [HttpGet]
        public async Task<>
    }
}        