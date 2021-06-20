namespace FrameworkUd01
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    using System.Threading;
    using FrameworkUd01.Utilities;

    [TestFixture]//, Ignore("Ignore a fixture")]
    //[Parallelizable]
    public class LoginInvalidPassword : TestBase
    {
        IAlert alert;

        [OneTimeSetUp]
        public void Initialize()
        {
            NavigateTo.LoginFormScenarioThroughTestCases(driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.FourCharacters, 
                Config.Credentials.Invalid.Password.FourCharacters, driver);

            alert = driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();

        }

        [Test]
        public void MoreThan12Chars()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username,
                Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, driver);

            alert = driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertsTexts.PasswordLenghtOutOfRange, alert.Text);
            alert.Accept();
        }

        //[OneTimeTearDown]
        //public void CleanUp()
        //{
        //    driver.Quit();
        //}
    }
}
