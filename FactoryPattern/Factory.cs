using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory_Pattern
{
    abstract class Page
    {

    }

    class IntroductionPage : Page
    {
    }

    class ContentPage : Page 
    { 
    }

    class ConclusionPage : Page
    {
    }


    abstract class Document
    {
        private List<Page> _Pages  = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _Pages; }
        }

        public abstract void CreatePages();

    }

    class report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ConclusionPage());
        }
    }

    class biography : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ContentPage());
            Pages.Add(new ConclusionPage());
        }
    }

}