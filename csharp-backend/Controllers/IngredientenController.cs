using Microsoft.AspNetCore.Mvc;
using mijnDBContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csharp_backend.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class IngredientenController : ControllerBase
    {
            private MijnDatabaseContext _db;
            public IngredientenController(MijnDatabaseContext db) {
                _db = db;
            }
            [HttpGet]
            public IEnumerable<Recept> Get()
            {
                Recept huis = new Recept();
                huis.ReceptName = "Vlakbij";
               huis.GebruikersNaam = "doen";
                _db.Add(huis);
                _db.SaveChanges();
                return _db.recepten;
            }

        // GET: api/<IngredientenController>


        // GET api/<IngredientenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IngredientenController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IngredientenController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IngredientenController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
