using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace mijnDBContext
{
    public class Recept
    {

       [Key]
       public int RecipeID { get; set; }
       public string RecipeTitle { get; set; }
       public int UserId { get; set; }
       public int PrepTime { get; set; }
       public string PrepText { get; set; }
       public int CookAttireId { get; set; }
       public int BBQId { get; set; }  
       //public int MealType { get; set; }
       //public bool IsVegan { get; set; }

       public int Rating { get; set; }
       public string Foto { get; set; }
       public string Intro { get; set;}

       // Try not to use nested types unless there's a clear benefit.
       public string Diet { get; set; }

       public string DateCreate { get; set; }
       //public string DateEdited { get; set; }
       // public List<Recept> Recepten {  get; set; } = new List<Recept>();
    }
}