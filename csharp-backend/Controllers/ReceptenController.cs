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
            return this._mdc.Recepten.ToList();
        }

        // GET api/<ReceptenController>/5
        [HttpGet("{id}")]
        public Recept? Get(int id)
        {
            return this._mdc.Recepten.Find(id);
        }

        // POST api/<ReceptenController>
        [HttpPost]
        public void Post([FromBody] Recept r)
        {
            this._mdc.Recepten.Add(r);
            this._mdc.SaveChanges();
        }

        // PUT api/<ReceptenController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Recept newRecept)
        {
            // openen
            Recept dbRecept = this._mdc.Recepten.Find(id);
            if (dbRecept == null)
                return false;

            // aanpassen
            dbRecept.ReceptName = newRecept.ReceptName;
            dbRecept.UploaderName = newRecept.UploaderName;
            dbRecept.CookingTime = newRecept.CookingTime;
            dbRecept.CookingDescription = newRecept.CookingDescription;
            dbRecept.UtensilsID = newRecept.UtensilsID; 
            dbRecept.BbqID = newRecept.BbqID;
           // dbRecept.MealType = newRecept.MealType;
            dbRecept.Rating = newRecept.Rating;
            dbRecept.RecipePhoto = newRecept.RecipePhoto;
            dbRecept.Intro = newRecept.Intro;
            dbRecept.DateCreate = newRecept.DateCreate;
            dbRecept.DateCreate = dbRecept.DateCreate;
            dbRecept.IsVegan = newRecept.IsVegan;

            // opslaan
            this._mdc.Recepten.Update(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }

        // DELETE api/<ReceptenController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de ingredient zoeken om te checken of deze wel bestaat
            Recept dbRecept = this._mdc.Recepten.Find(id);
            if (dbRecept == null)
                return false;

            // dan ingredient verwijderen
            this._mdc.Recepten.Remove(dbRecept);
            this._mdc.SaveChanges();

            return true;
        }
    }
}
