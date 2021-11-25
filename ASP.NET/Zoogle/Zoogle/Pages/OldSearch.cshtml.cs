using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zoogle.Pages
{
    public class OldSearchModel : PageModel
    {
        public IActionResult OnGet()
        {
            return RedirectToPage("/Search");
        }

        public IActionResult OnPost()
        {
            return NotFound();
        }
    }
}
