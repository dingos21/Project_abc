using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUd01.Scenarios
{
    [TestFixture]//, Ignore("Ignore a fixture")]
    public class Zd_OpenNewTabs
    {
        [Test]//, Ignore("Ignore a test")]
        public void OpenNewTabInChrome1()
        {
            List<string> handles = new List<string>();

            IWebDriver driver = Action.InitializeDriver(2);
            IWebElement newTab;
            IWebElement newWindow;
            string url = "http://testing.todorvachev.com/tabs-and-windows/new-tab/";
            string newTabSelector = "#post-182>div>p:nth-child(1) > a:nth-child(1)";  // Tab  //a[target='http://google.com']
            string newWindowSelector = "#post-182>div>p:nth-child(1) > a:nth-child(3)";
            driver.Navigate().GoToUrl(url);
            newTab = driver.FindElement(By.CssSelector(newTabSelector));
            newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

            newTab.Click();
            handles = driver.WindowHandles.ToList();
            //           for (int i = 0; i < handles.Count; i++)  Console.WriteLine(handles[i]);  // to see the tabs on consule.

            driver.SwitchTo().Window(handles[1]);
            IWebElement searcBox = driver.FindElement(By.Name("q"));
            searcBox.SendKeys("Selenium");
            searcBox.Submit();
            Action.waitPlease(2);
            driver.Close();
            Action.waitPlease(2);
            driver.Quit();

        }

        [Test]//, Ignore("Ignore a test")]
        public void WindowSizeAndPositionIE()
        {
            Size size = new Size();
            size.Width = 300;
            size.Height = 500;

            Point position = new Point();
            position.X = 100;
            position.Y = 50;

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
            driver.Manage().Window.Size = size;                     // driver.Manage().Window.Size = new Size(60,60);
            Action.waitPlease(1);
            driver.Manage().Window.Position = position;             // driver.Manage().Window.Position = new Point(0,0);
            Action.waitPlease(1);
            driver.Manage().Window.Size = new Size(600,800);
            Action.waitPlease(1);
            driver.Manage().Window.Position = new Point(300,100);
            Action.waitPlease(1);
            driver.Manage().Window.Minimize();
            Action.waitPlease(1);
            driver.Manage().Window.Maximize();
            Action.waitPlease(1);
            driver.Quit();
        }

        [Test, Ignore("Ignore a test")]
        public void OpenNewTabinIE()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl("http://google.com");
            //driver.Manage().Window.Size = new Size(600, 600);
            //driver.Manage().Window.Position = new Point(60, 100);
            Action.waitPlease(2);
            driver.Manage().Window.Maximize();
            driver.Quit();

            //Actions actions1 = new Actions(driver);
            //actions1.KeyDown(Keys.Control).SendKeys("t").Build().Perform();
            //Action.waitPlease(2);
            //Actions actions2 = new Actions(driver);
            //actions2.KeyDown(Keys.Control).SendKeys("t").Build().Perform();
            //Action.waitPlease(2);
            //driver.Quit();
        }

        [Test]//, Ignore("Ignore a test")]
        public void OpenNewTabInChrome2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.Control + "t").Build().Perform();
            // open tabs on the same window.
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            // open differant web pages on those created tabs.
            List<string> handles = driver.WindowHandles.ToList();

            driver.SwitchTo().Window(handles[1]);
            driver.Navigate().GoToUrl("http://google.com");
            driver.SwitchTo().Window(handles[2]);
            driver.Navigate().GoToUrl("http://amazon.com");
            driver.SwitchTo().Window(handles[3]);
            driver.Navigate().GoToUrl("http://ebay.com");
            driver.SwitchTo().Window(handles[4]);
            driver.Navigate().GoToUrl("http://alibaba.com");
            driver.SwitchTo().Window(handles[5]);
            driver.Navigate().GoToUrl("http://alliedsolutions.net");

            for (int i = 0; i < handles.Count; i++)
                if (i != 5) driver.SwitchTo().Window(handles[i]).Close();

            Action.waitPlease(2);
            driver.Quit();
        }

    }
}
