using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Policy;
using ValidateSite.SiteService;

namespace ValidateSite.Pages.ValidateSitePage
{
    public class IndexModel : PageModel
    {
        IValidateSite _validateSite;
        public IndexModel(IValidateSite validateSite)
        {
            _validateSite = validateSite;
            test1 = "";
        }
        public string test1 { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            test1 = Request.Form["url"];
            string url = test1;
            test1 =  _validateSite.ValidSiteName(url);
            if(test1 == url)
            {
                test1 = "Valid site.";
            }
            else
            {
                test1 = "Not a Valid site.";
            }

            return Page();
        }
    }
}
