using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUd01.Scenarios
{
    [TestFixture]//, Ignore("Ignore a fixture")]
    //[Parallelizable(ParallelScope.None)]
    [Parallelizable]
    public class Zc_DragAndDrop
    {
        IWebDriver driver;
        IWebElement image;
        string URL = "http://testing.todvachev.com/draganddrop/draganddrop.html";
        string lightGreen;


        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Action.InitializeDriver(2);
            driver.Navigate().GoToUrl(URL);
            Action.waitPlease(2);
        }

        [Test]
        public void MoveToElement1()
        {
            string[] elementsIDs = { "Drag1", "Drag2", "Drag3", "Drag4", "Drag5" };
            IWebElement[] elements = {  driver.FindElement(By.Id(elementsIDs[0])),
                                        driver.FindElement(By.Id(elementsIDs[1])),
                                        driver.FindElement(By.Id(elementsIDs[2])),
                                        driver.FindElement(By.Id(elementsIDs[3])),
                                        driver.FindElement(By.Id(elementsIDs[4]))    };
            lightGreen = "rgba(144, 238, 144, 1)";

            Actions actions = new Actions(driver);
            actions.MoveToElement(elements[0]).Build().Perform();
            Console.WriteLine();
            Console.WriteLine("Backround color is : " + elements[0].GetCssValue("background-color"));
            Assert.IsTrue(elements[0].GetCssValue("background-color") == lightGreen );
        }

        [Test]
        public void DragAndDrop1()
        {
            string[] elementsIDs = { "Drag1", "Drag2", "Drag3", "Drag4", "Drag5" };
            IWebElement[] elements = {  driver.FindElement(By.Id(elementsIDs[0])),
                                        driver.FindElement(By.Id(elementsIDs[1])),
                                        driver.FindElement(By.Id(elementsIDs[2])),
                                        driver.FindElement(By.Id(elementsIDs[3])),
                                        driver.FindElement(By.Id(elementsIDs[4]))    };
            lightGreen = "rgba(144, 238, 144, 1)";

            Actions actions = new Actions(driver);
            MoveElement(new Actions(driver), elements[0], elements[1], 0, 10); // MoveByOffset( X ofset value, Y ofset value)
            Action.waitPlease(1);
            MoveElement(new Actions(driver), elements[0], elements[2], 0, 10);
            Action.waitPlease(1);
            MoveElement(new Actions(driver), elements[4], elements[1], 0, 10);
            Action.waitPlease(1);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

        static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            actions.ClickAndHold(from)
                .MoveToElement(to)
                .MoveByOffset(x, y)
                .Release()
                .Build()
                .Perform();
        }

    }
}
