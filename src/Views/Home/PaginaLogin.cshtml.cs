using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Models;

namespace project.Views.Home
{
    public class PaginaLoginModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }

        public IActionResult OnPost()
        {
            // Debug: Check if the Usuario object is populated correctly
            var teste = Usuario?.Email;

            if (!ModelState.IsValid)
            {
                return Page(); // Return the same page on validation failure
            }

            // Authentication logic or other actions
            return RedirectToPage("/Home/Index"); // Redirect on success
        }

        public void OnGet()
        {
        }
    }


}
