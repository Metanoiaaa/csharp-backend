using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mijnDBContext
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public string DateofBirth { get; set; }

        public int Uploads { get; set; }

        public int Bio { get; set; }

        public string DateCreate { get; set; }

        public string ProfilePicture { get; set; }


    }
}
