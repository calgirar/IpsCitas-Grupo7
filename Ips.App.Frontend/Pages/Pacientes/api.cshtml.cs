using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ips.App.Frontend.Pages
{
    public class apiModel : PageModel
    {
        
        public IActionResult OnGet()
        {
            Response.StatusCode = 400;
            return new JsonResult(new { message = "Error" } );
        }
    }
}
