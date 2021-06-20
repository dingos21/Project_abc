using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUd01.Pages
{
    public class TestScenariosPage
    {
        public TestScenariosPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using =
            ".category-test-scenarios.format-standard.has-post-thumbnail.hentry.mh-loop-item.post.post-72.status-publish.type-post a[rel='bookmark']")]
        public IWebElement LoginFormScenario { get; set; }

        
    }
}
