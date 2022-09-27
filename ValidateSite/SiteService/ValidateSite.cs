using System.Collections.Generic;
using System.Linq;

namespace ValidateSite.SiteService
{
    public class ValidateSite : IValidateSite
    {
        public static List<ValidSite> ValidSites = new List<ValidSite>(); 
         public ValidateSite()
        {
            ValidSites.Add(new ValidSite("https://www.flipkart.com/"));
        }
       
        public string ValidSiteName(string url)
        {
            foreach (var site in ValidSites)
                if (site.Url == url)
                    return url;
            return null;
            
        }
    }
}
