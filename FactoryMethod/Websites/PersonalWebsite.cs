using System;
using FactoryMethod.WebPages;

namespace FactoryMethod.Websites
{
    public class PersonalWebsite : Website
    {
        public override void Create()
        {
            WebPages.Add(new ProfilePage());
            WebPages.Add(new ContactPage());
        }
    }
}
