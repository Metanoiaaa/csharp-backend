using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace mijnDBContext
{
    public class Recept
    {
        public int Id { get; set; }
        public string ReceptName { get; set; }
        public string GebruikersNaam {  get; set; }

       // public List<Recept> Recepten {  get; set; } = new List<Recept>();

    }
}