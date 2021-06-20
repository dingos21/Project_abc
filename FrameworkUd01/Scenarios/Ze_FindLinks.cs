using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUd01.Scenarios
{
    [TestFixture]//, Ignore("Ignore a fixture")]
    [Category("ASmokeTests")]
    public class Ze_FindLinks
    {
        IWebDriver driver;
        string sitemapURL = "http://testing.todorvachev.com/sitemap-posttype-post.xml";
        string[] pageSource;
        List<string> extractedLinks = new List<string>();
        int startIndex;
        int endIndex;
        int linkLenghth;

        [OneTimeSetUp]
        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(sitemapURL);

        }
        [Test]
        public void TestMethod()
        {
            pageSource = driver.PageSource.Split('>','<');   // splited by spaces
            int i = 1;
            foreach (var item in pageSource)
                if (item.Contains("https://testing.todorvachev.com/") && !item.Contains("href"))
                    extractedLinks.Add(item);

            Console.WriteLine();
            foreach (var item in extractedLinks) Console.WriteLine(i++ + ":" + item);

        }
    }
}

//	"href=\"https://testing.todorvachev.com/tabs-and-windows/new-tab/\"
//           >https://testing.todorvachev.com/tabs-and-windows/new-tab/
//            </a></td><td></td><td>20%</td><td>2017-05-01"	string
