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
    public class Driverrrr
    {
        private static IWebDriver driver;

        private Driverrrr()
        {
        }

        public static IWebDriver GetDriver(string browser, int second)
        {
  //          browser = browser.ToLower().Trim();
            switch (browser)
            {
                case "chrome":
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(Config.BaseURL);
                    break;
                case "chromeHeadless":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    driver = new ChromeDriver(options);
                    break;
                case "firefox":
                        driver = new FirefoxDriver();
                    break;
                case "firefoxHeadless":
                    FirefoxOptions ffopt = new FirefoxOptions();
                    ffopt.AddArgument("--headless");
                    driver = new FirefoxDriver(ffopt);
                    break;
                case "ie":
                    driver = new InternetExplorerDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "safari":
                    driver = new SafariDriver();
                    break;
                default:
                    throw new Exception("Illegal browser type!");
            }
            
            TimeSpan seconds = TimeSpan.FromSeconds(second);
            driver.Manage().Timeouts().ImplicitWait = seconds;
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static IWebDriver GetDriver()
        {
            return GetDriver("chrome", 2);
        }

        public static void CloseDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }


        }



}
