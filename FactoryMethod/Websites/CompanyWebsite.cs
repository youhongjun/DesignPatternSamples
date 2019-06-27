using System;
using FactoryMethod.WebPages;

namespace FactoryMethod.Websites
{
    public class CompanyWebsite : Website
    {
        public override void Create()
        {
            WebPages.Add(new LoginPage());
            WebPages.Add(new ProductPage());
            WebPages.Add(new ProjectPage());
            WebPages.Add(new ContactPage());
        }
    }
}
