using Hidalgo_Yanez.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hidalgo_Yanez.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public ValuesController(AplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> GetAction() {
            //if(_context.Generos == null) return NotFound();
            //return await _context.Generos.ToListAsync();
            var l = await _context.Generos.OrderBy(r => r.Id).ToListAsync();
            return Ok(l);
        }
    }
}
