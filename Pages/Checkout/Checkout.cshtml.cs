using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string MarimeGhete { get; set; }
        public float PretGhete { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(MarimeGhete))
            {
                MarimeGhete = "Custom";
            }
            if (string .IsNullOrEmpty(ImageTitle) )
            { ImageTitle = "personalizeaza";
            }
            }
        
    }
}
