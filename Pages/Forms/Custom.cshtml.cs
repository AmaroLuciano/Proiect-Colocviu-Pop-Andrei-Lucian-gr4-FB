using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Models;

namespace Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Pages.Forms
{
    public class CustomModel : PageModel
    {
        [BindProperty]
        public Models.GheteModels Ghete { get; set; }
        public float PretGhete { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost ()
        {
            PretGhete = Ghete.BasePrice;

            if (Ghete.CrampoaneMetal) PretGhete += 100;
            if (Ghete.CrampoanePlastic) PretGhete += 70;
            if (Ghete.CrampoaneMixte) PretGhete += 115;
            if (Ghete.CrampoaneSintetic) PretGhete += 60;
            if (Ghete.TalpăSală) PretGhete += 50;

            return RedirectToPage("/CheckOut/CheckOut", new { Ghete.MarimeGhete , PretGhete } );
                   
        }
    }
}
