using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrameworkUd01.Pages
{
    public class SpecialElementsPage
    {
        public SpecialElementsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

    }
}
