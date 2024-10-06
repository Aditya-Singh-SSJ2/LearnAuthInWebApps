using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnRazorWebApps.Pages
{
    [Authorize]
    public class aboutModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
