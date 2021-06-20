using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUd01.Pages
{
    public class TestCasesPage
    {
        public TestCasesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".category-test-cases.format-standard.has-post-thumbnail.hentry.mh-loop-item.post.post-74.status-publish.type-post a[rel = 'bookmark']")]
        public IWebElement UsernameCase { get; set; }

    }
}
