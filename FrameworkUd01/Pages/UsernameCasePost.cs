using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUd01.Pages
{
    public class UsernameCasePost
    {
        public UsernameCasePost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}
