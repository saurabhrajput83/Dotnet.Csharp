using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    #region Product

    public abstract class Page
    {

    }

    #endregion

    #region Concrete Product

    public class PersonalDetailsPage : Page
    {

    }

    public class SkillsPage : Page
    {

    }

    public class EducationPage : Page
    {

    }

    public class ExperiencePage : Page
    {

    }

    public class IntroductionPage : Page
    {

    }

    public class ResearchPage : Page
    {

    }

    public class ResultsPage : Page
    {

    }

    public class ConclusionPage : Page
    {

    }
    #endregion

    #region Creator

    public abstract class Document
    {
        private List<Page> _pages;

        public Document()
        {
            _pages = new List<Page>();
            this.CreatePages();
        }

        public List<Page> Pages { get { return _pages; } }

        public abstract void CreatePages();
    }

    #endregion

    #region Concrete Creator

    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new PersonalDetailsPage());
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResearchPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
        }
    }

    #endregion
}
