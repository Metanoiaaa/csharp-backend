using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace mijnDBContext
{
    public class Recept
    {
       public int Id { get; set; }
       public string ReceptName { get; set; }
       public string UploaderName { get; set; }
       public int CookingTime { get; set; }
       public string CookingDescription { get; set; }
       public int UtensilsID { get; set; }
       public int BbqID { get; set; }  
       public int MealType { get; set; }
       public bool IsVegan { get; set; }
       public int Rating { get; set; }
       public string RecipePhoto { get; set; }
       public string Intro { get; set;}
       public int Diet { get; set; }
       public string DateCreate { get; set; }
       public string DateEdited { get; set; }
        // public List<Recept> Recepten {  get; set; } = new List<Recept>();
    }
}