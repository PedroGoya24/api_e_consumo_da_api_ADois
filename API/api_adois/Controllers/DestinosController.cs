using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_adois.Data;
using api_adois.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_adois.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public DestinosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destinos>>> GetDestinos()
        {
            return await _dataContext.Destinos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Destinos>> GetDestinoById(int id)
        {
            var Dest = await _dataContext.Destinos.FindAsync(id);

            if (Dest == null)
            {
                return NotFound();
            }
            return Ok(Dest);

        }
    }

}
