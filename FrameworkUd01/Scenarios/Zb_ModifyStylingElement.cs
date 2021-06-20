using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  for different js codes go to wwww.w3schools.com/cssref/
namespace FrameworkUd01.Scenarios
{
    [TestFixture]//, Ignore("Ignore a fixture")]
    //[Parallelizable(ParallelScope.None)]
    [Parallelizable]
    public class Zb_ModifyStylingElement
    {
        IWebDriver driver;
        IWebElement image;
        IWebElement content;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Action.InitializeDriver(2);
        }

        [Test]
        public void DisappearElement()
        {
            image = driver.FindElement(By.CssSelector("img[class='alignnone wp-image-37 size-full']"));

            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            string script = "arguments[0].style[\"display\"] = \"none\"";

            jsExecutor.ExecuteScript(script, image);
            Action.waitPlease(2);

        }

        [Test]
        public void ZChangeColorOfElement()
        {
            content = driver.FindElement(By.CssSelector("#page-17 > div"));

            IJavaScriptExecutor jsExecuter = (IJavaScriptExecutor)driver;
            string script = "arguments[0].style[\"color\"] = \"red\"";

            jsExecuter.ExecuteScript(script, content);
            Action.waitPlease(2);
        }

        [Test]
        public void ZChangeColorOfElement2()
        {
           Action.SetStyle(driver, content, "color", "green");
           Action.waitPlease(2);
        }
        [Test]
        public void ZDroveBorderElement()
        {
            content = driver.FindElement(By.CssSelector("#page-17 > div"));

            IJavaScriptExecutor jsExecuter = (IJavaScriptExecutor)driver;
            string script = "arguments[0].style[\"border\"] = \"5px solid red\"";

            jsExecuter.ExecuteScript(script, content);
            Action.waitPlease(2);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
