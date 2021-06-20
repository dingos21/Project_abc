using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUd01.Utilities
{
    public class TestBase
    {
        protected IWebDriver driver;
        IAlert alert;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = Driver.InitializeDriver(Driver.Browser.Chrome, 3);
        }

   
        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

    }
}
