using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMiniProject.Pages
{
    public class AddressInfoModel : PageModel
    {
        [BindProperty]
        public string Street { get; set; }
        [BindProperty]
        public string State { get; set; }
        [BindProperty]
        public string ZipCode { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
