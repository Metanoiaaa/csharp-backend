using Microsoft.AspNetCore.Mvc;
using mijnDBContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csharp_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientenController : ControllerBase
    {
        private MijnDatabaseContext _mdc;

        public IngredientenController(MijnDatabaseContext mdc)
        {
            _mdc = mdc;
        }

        // GET: api/<IngredientenController>
        [HttpGet]
        public List<Ingredient> Get()
        {
            return this._mdc.Ingredienten.ToList();
        }

        // GET api/<IngredientenController>/5
        [HttpGet("{id}")]
        public Ingredient? Get(int id)
        {
            return this._mdc.Ingredienten.Find(id);
        }

        // POST api/<IngredientenController>
        [HttpPost]
        public void Post([FromBody] Ingredient i)
        {
            this._mdc.Ingredienten.Add(i);
            this._mdc.SaveChanges();
        }

        // PUT api/<IngredientenController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Ingredient newIngredient)
        {
            // openen
            Ingredient dbIngredient = this._mdc.Ingredienten.Find(id);
            if (dbIngredient == null)
                return false;

            // aanpassen
            dbIngredient.Name = newIngredient.Name;


            // opslaan
            this._mdc.Ingredienten.Update(dbIngredient);
            this._mdc.SaveChanges();

            return true;
        }

        // DELETE api/<IngredientenController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de ingredient zoeken om te checken of deze wel bestaat
            Ingredient dbIngredient = this._mdc.Ingredienten.Find(id);
            if (dbIngredient == null)
                return false;

            // dan ingredient verwijderen
            this._mdc.Ingredienten.Remove(dbIngredient);
            this._mdc.SaveChanges();

            return true;
        }
    }
}
