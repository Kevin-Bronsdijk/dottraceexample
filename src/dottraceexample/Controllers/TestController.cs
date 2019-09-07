using System.Threading.Tasks;
using dottraceexample.Models;
using dottraceexample.Services;
using Microsoft.AspNetCore.Mvc;

namespace dottraceexample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ISlowService _slowService;

        public TestController(ISlowService slowService)
        {
            _slowService = slowService;
        }
        
        [HttpGet()]
        public async Task<ActionResult<GetNumberResponse>> GetNumberAsync()
        {
            var response = await _slowService.GetNumberAsync();
            
            var result = new GetNumberResponse
            {
                Value = response
            };
            
            return result;
        }
    }
}