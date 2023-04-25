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
        public List<Recept> Get()
        {
            return this._mdc.recepten.ToList();
        }

        // GET api/<ReceptenController>/5
        [HttpGet("{id}")]
        public Recept? Get(int id)
        {
            return this._mdc.recepten.Find(id);
        }

        // POST api/<ReceptenController>
        [HttpPost]
        public void Post([FromBody] Recept r)
        {
            this._mdc.recepten.Add(r);
            this._mdc.SaveChanges();
        }

        // PUT api/<ReceptenController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Recept newRecept)
        {
            // openen
            Recept dbRecept = this._mdc.recepten.Find(id);
            if (dbRecept == null)
                return false;

            // aanpassen
            dbRecept.ReceptName = newRecept.ReceptName;
            dbRecept.Vegan = newRecept.Vegan;
            dbRecept.Gebruikersnaam = newRecept.Gebruikersnaam;

            // opslaan
            this._mdc.recepten.Update(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }

        // DELETE api/<ReceptenController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de ingredient zoeken om te checken of deze wel bestaat
            Recept dbRecept = this._mdc.recepten.Find(id);
            if (dbRecept == null)
                return false;

            // dan ingredient verwijderen
            this._mdc.recepten.Remove(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }
    }
}
