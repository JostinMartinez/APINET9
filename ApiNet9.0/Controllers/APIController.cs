using ApiNet9._0.Data;
using ApiNet9._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiNet9._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController(ApiDbContext context) : ControllerBase
    {

        private readonly ApiDbContext _context = context;


        [HttpGet]
        public async Task<ActionResult<List<ApiModel>>> GetModels()
        {
            return Ok(await _context.ApiModels.ToListAsync());
        }
    }
}
