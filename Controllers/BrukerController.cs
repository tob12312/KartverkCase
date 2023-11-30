using KartverkCase.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KartverkCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrukerController : ControllerBase
    {
        private readonly DbContextt _context;
        // instansier DB
        public BrukerController(DbContextt context)
        {
            _context = context;
        }

        //returnerer liste av brukere - kan være flere brukere med samme param
      //  [Authorize(Roles ="Ansatt")]
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Bruker>>> FiltrerBruker([FromQuery] string query)
        {
            return await _context.Brukere
                .Where(bruker =>
                    bruker.Fornavn.Contains(query)   ||
                    bruker.Adresse.Contains(query)   ||
                    bruker.TelefonNr.Contains(query) ||
                    bruker.Epost.Contains(query)     ||
                    bruker.Etternavn.Contains(query)
                    )
                .ToListAsync();
        }





        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bruker>>> GetBrukere()
        {
            var brukerliste = await _context.Brukere.OrderBy(brukere => brukere.Fornavn).ToListAsync();
            return brukerliste;
        }


        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
