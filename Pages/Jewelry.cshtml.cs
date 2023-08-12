using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapp.WebSite.Models;

namespace Webapp.WebSite.Pages
{
	public class Jewelry : PageModel
    {

        [BindProperty]
        public Product NewProduct { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage();
        }
    }
}
