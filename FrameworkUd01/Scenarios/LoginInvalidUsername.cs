namespace FrameworkUd01
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Chrome;
    using FrameworkUd01.Utilities;

    [TestFixture]//, Ignore("Ignore a fixture")]
    //[Parallelizable]            //[Parallelizable(ParallelScope.None)]
    //[Category("ASmokeTests")]
    public class LoginInvalidUsername
    {
        IAlert alert;
        IWebDriver driver;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Driver.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughMenu(driver);
        }

        [Test, Order(1), Description("LessThan5Chars")]
        public void LessThan5Chars()
        {
            Action.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, 
                Config.Credentials.Valid.Password,
                Config.Credentials.Valid.Password, driver);

            alert = driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
            Action.waitPlease(3);
        }

        [Test, Order(2), Description("MoreThan12Chars")]
        public void MoreThan12Chars()
        {
            Action.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, driver);

            alert = driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
            Action.waitPlease(3);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
