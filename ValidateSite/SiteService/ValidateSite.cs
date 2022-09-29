using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;

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
            string regex = (@"((http|https)://)(www.)?" +
             "[a-zA-Z0-9@:%._\\+~#?&//=]" +
             "{2,256}\\.[a-z]" +
             "{2,6}\\b([-a-zA-Z0-9@:%" +
             "._\\+~#?&//=]*)");
            Regex re = new Regex(regex);
            // Compile the ReGex


            if (re.IsMatch(url))
            {
                foreach (var site in ValidSites)
                    if (site.Url == url)
                        return url;
            }
            return null;         
        }
    }
}
