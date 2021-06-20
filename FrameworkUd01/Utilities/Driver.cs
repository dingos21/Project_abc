using FrameworkUd01.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace FrameworkUd01
{
    public static class Driver
    {
        private static IWebDriver driver;
        public enum Browser
        {
            Chrome, ChromeHeadless,
            Firefox, FirefoxHeadless,
            IE,
            Safari,
            Edge
        }

        public static IWebDriver InitializeDriver(Browser browser, int second)
        {
 //           IWebDriver driver;
            switch (browser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(Config.BaseURL);
                    break;
                case Browser.ChromeHeadless:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    driver = new ChromeDriver(options);
                    break;
                case Browser.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case Browser.FirefoxHeadless:
                    FirefoxOptions ffopt = new FirefoxOptions();
                    ffopt.AddArgument("--headless");
                    driver = new FirefoxDriver(ffopt);
                    break;
                case Browser.IE:
                    driver = new InternetExplorerDriver();
                    break;
                case Browser.Edge:
                    driver = new EdgeDriver();
                    break;
                case Browser.Safari:
                    driver = new SafariDriver();
                    break;
                default:
                    throw new Exception("****************** ILLEGAL BROWSR TYPE! ******************");
            }

            driver.Navigate().GoToUrl(Config.BaseURL);
            
            TimeSpan seconds = TimeSpan.FromSeconds(second);
            driver.Manage().Timeouts().ImplicitWait = seconds;
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static IWebDriver InitializeDriver()
        {
            return InitializeDriver(Driver.Browser.Chrome, 2);
        }



    }
}
