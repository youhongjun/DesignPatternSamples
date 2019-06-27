using System;
using System.Collections.Generic;
using FactoryMethod.WebPages;

namespace FactoryMethod.Websites
{
    public abstract class Website
    {
        private List<WebPage> _pages = new List<WebPage>();

        public Website() => Create();

        public List<WebPage> WebPages
        {
            get { return _pages; }
        }

        public abstract void Create();
    }
}
