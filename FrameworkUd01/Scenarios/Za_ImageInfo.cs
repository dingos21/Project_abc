using NUnit.Framework;
using OpenQA.Selenium;
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
    public class Za_ImageInfo
    {
        IWebDriver driver;
        IWebElement image;

        [OneTimeSetUp]
        public void Initialize()
        {
            driver = Action.InitializeDriver(2);
        }
        [Test]
        public void ImageLocation()
        {
            image = driver.FindElement(By.CssSelector("img[class='alignnone wp-image-37 size-full']"));
            Console.WriteLine();
            Console.WriteLine("Image location of X axes: "+image.Location.X);
            Console.WriteLine("Image location of Y axes: " + image.Location.Y);
        }
        [Test]
        public void ImageSize()
        {
            image = driver.FindElement(By.CssSelector("img[class='alignnone wp-image-37 size-full']"));
            Console.WriteLine();
            Console.WriteLine("Image With: " + image.Size.Width);
            Console.WriteLine("Image Hight: " + image.Size.Height);
        }
        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Quit();
        }
    }
}
