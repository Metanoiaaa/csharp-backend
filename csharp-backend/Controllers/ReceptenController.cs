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
            return this._mdc.recipes.ToList();
        }

        // GET api/<ReceptenController>/5
        [HttpGet("{id}")]
        public Recept? Get(int id)
        {
            return this._mdc.recipes.Find(id);
        }

        // POST api/<ReceptenController>
        [HttpPost]
        public void Post([FromBody] Recept r)
        {
            this._mdc.recipes.Add(r);
            this._mdc.SaveChanges();
        }

        // PUT api/<ReceptenController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Recept newRecept)
        {
            // openen - Regel 46 is iets mee.
            Recept dbRecept = this._mdc.recipes.Find(id);
            if (dbRecept == null)
                // return false;
               return false;

            // aanpassen

            dbRecept.Title = newRecept.Title;
            dbRecept.UserId = newRecept.UserId;
            dbRecept.PrepTime = newRecept.PrepTime;
            dbRecept.PrepText = newRecept.PrepText;
            dbRecept.CookAttireId = newRecept.CookAttireId; 
            dbRecept.BBQId = newRecept.BBQId;
            //dbRecept.MealType = newRecept.MealType;

            dbRecept.Rating = newRecept.Rating;
            dbRecept.Foto = newRecept.Foto;
            dbRecept.Intro = newRecept.Intro;
            dbRecept.DateCreate = newRecept.DateCreate;
            //dbRecept.DateEdited = dbRecept.DateEdited;
            dbRecept.Diet = dbRecept.Diet;
            //dbRecept.IsVegan = newRecept.IsVegan;

            // opslaan
            this._mdc.recipes.Update(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }

        // DELETE api/<ReceptenController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de ingredient zoeken om te checken of deze wel bestaat
            Recept dbRecept = this._mdc.recipes.Find(id);
            if (dbRecept == null)
                return false;

            // dan ingredient verwijderen
            this._mdc.recipes.Remove(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }
    }
}
