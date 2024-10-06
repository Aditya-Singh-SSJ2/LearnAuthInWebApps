using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace LearnRazorWebApps.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        public string username { get; private set;}
        public string userEmail { get; private set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public int displayInteger { get; set; }
        [BindProperty]
        public int myNumber { get; set; }

        public void OnGet()
        {
            if (User.Identity.IsAuthenticated)
            {
                username = User.FindFirst(ClaimTypes.Name)?.Value;
                userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
            }
            var rand = new Random();
            displayInteger = rand.Next();
        }

        public void OnPost()
        {
            displayInteger = myNumber;
        }
    }
}
