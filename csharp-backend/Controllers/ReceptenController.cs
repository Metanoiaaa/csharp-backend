using Microsoft.AspNetCore.Mvc;
using mijnDBContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csharp_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptenController : ControllerBase
    {
        private MijnDatabaseContext _mdc;

        public ReceptenController(MijnDatabaseContext mdc)
        {
            _mdc = mdc;
        }


        // GET: api/<ReceptenController>
        [HttpGet]
        public IEnumerable<Recept> Get()
        {
            Recept recept = new Recept();
            recept.ReceptName = "Broodje bal";
            recept.Gebruikersnaam = "David";
            recept.Vegan = false;
            recept.Rating = 5;
            _mdc.Add(recept);
            _mdc.SaveChanges();

            return _mdc.recepten;
        }

        // GET api/<ReceptenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReceptenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReceptenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReceptenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
