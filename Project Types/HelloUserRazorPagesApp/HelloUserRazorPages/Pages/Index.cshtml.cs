using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloUserRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        [BindProperty]
        public string LastName { get; set; }

        public string Message { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            Message = $"Hello, {FirstName} {LastName}";
            return Page();
        }
    }
}
