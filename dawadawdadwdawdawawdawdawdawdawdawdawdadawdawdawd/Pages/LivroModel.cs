using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SeuNamespace.Pages
{
 public class LivroModel : PageModel
    {
        public int Id { get; set; }
 public string? Titulo { get; set; } 
 public string? Autor { get; set; } 
 public void OnGet(int id)
  {
  Id = id;
   Titulo = "Jujutsu Kaisen";
   Autor = "Gege Akutami";
   }
 }
}
