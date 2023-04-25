using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace mijnDBContext
{
    public class Recept
    {
        public int Id { get; set; }
        public string ReceptName { get; set; }
        public string Gebruikersnaam { get; set; }
        public bool Vegan { get; set; }
        public int Rating { get; set; }


        // public List<Recept> Recepten {  get; set; } = new List<Recept>();

    }
}