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
        public List<User> Get()
        {

            return this._mdc.Users.ToList();

        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return this._mdc.Users.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User i)
        {
            this._mdc.Users.Add(i);
            this._mdc.SaveChanges();

            return i;
        }



        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] User NewUser)
        {
            // Openen
            User dbUser = this._mdc.Users.Find(id);
            if (dbUser == null)
                return false;
            // Aanpassen
            dbUser.Firstname = NewUser.Firstname;
            dbUser.Lastname = NewUser.Lastname;
            dbUser.Username = NewUser.Username;
            dbUser.Email = NewUser.Email;
            dbUser.DateofBirth = NewUser.DateofBirth;
            dbUser.Uploads = NewUser.Uploads;   
            dbUser.Bio = NewUser.Bio;
            dbUser.DateCreate = NewUser.DateCreate;
            dbUser.ProfilePicture = NewUser.ProfilePicture;
            dbUser.Password = NewUser.Password;

            // Opslaan
            this._mdc.Users.Update(dbUser);
            this._mdc.SaveChanges();

            return true;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            // eerst de User zoeken
            User dbUser = this._mdc.Users.Find(id);
            if (dbUser == null)
                return false;

            this._mdc.Users.Remove(dbUser);
            this._mdc.SaveChanges();
            return true;

        }
    }
}
