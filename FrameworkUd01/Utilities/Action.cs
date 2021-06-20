using FrameworkUd01.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace FrameworkUd01
{
    public static class Action
    {

        public static IWebDriver InitializeDriver(int second)
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            
            TimeSpan seconds = TimeSpan.FromSeconds(second);
            driver.Manage().Timeouts().ImplicitWait = seconds;
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost(driver);

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }

        /**
  * This method will put on pause execution
  *
  * @param seconds
  */
        public static void waitPlease(int seconds)
        {
            try
            {
                Thread.Sleep(seconds * 1000);
            }
            catch (Exception e)
            {
                Console.WriteLine("wait....");
            }

        }


        public static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style, styleValue);
            jsExecutor.ExecuteScript(script, element);
  
        }




    }
}
