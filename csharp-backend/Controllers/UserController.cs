using Microsoft.AspNetCore.Mvc;
using mijnDBContext;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace csharp_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {
        private MijnDatabaseContext _mdc;
        public UserController(MijnDatabaseContext mdc)
        {
            _mdc = mdc;
        }
    
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            User Twan = new User();
            Twan.Firstname = "Twan";
            Twan.Lastname = "Biessen";
            Twan.Email = "twanaap48@yahoo.nl";
            Twan.Password = "password";
            Twan.Username = "username";
            Twan.DateofBirth = "22/04/1995";
            Twan.Uploads = 11;
            Twan.DateCreate = "Vandaag";
            Twan.Bio = "Ik vind koken leuk";
            Twan.ProfilePicture = "asd";
            _mdc.Add(Twan);
            _mdc.SaveChanges();
            return _mdc.Users;

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
