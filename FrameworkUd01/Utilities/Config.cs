using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkUd01
{
    public static class Config
    {
        public static int ElementsWaitingTimeout = 5;
        public static string BaseURL = "http://testing.todorvachev.com";





        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "example@example.com";
                public static string Username = "Username";
                public static string Password = "password123!";
            }

            public static class Invalid
            {
                public static class Email
                {
                    public static string NoUser = "@example.com";
                    public static string NoAt = "exampleexample.com";
                    public static string NoDomain = "example@";
                    public static string NoExtension = "example@example";
                }

                public static class Username
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }

                public static class Password
                {
                    public static string FourCharacters = "abcd";
                    public static string ThirteenCharacters = "abcdabcdabcda";
                    public static string OnlyLetters = "abcdabcd";
                    public static string OnlyNumbers = "123456789";
                    public static string OnlySpecialSymbols = "$#@%)(*$%#%?><";
                    public static string NoSpecialSymbol = "asd1234";
                }
            }
        }

        public static class MenuElements
        {
            public static string Introduction = "Introduction";
            public static string Selectors = "Selectors";
            public static string SpecialElements = "Special Elements";
            public static string TestCases = "Test Cases";
            public static string TestScenarios = "Test Scenarios";
            public static string About = "About";
        }

        public static class TestMessages
        {

        }

        public static class AlertsTexts
        {
            public static string UsernameLengthOutOfRange = "User Id should not be empty / length be between 5 to 12";
            public static string PasswordLenghtOutOfRange = "Password should not be empty / length be between 5 to 12";
            public static string SuccessfulLogin = "Succesful login!";
        }

        /*
            public class Driver {
            private static IWebDriver driver;

            private Driver() {
            }

            public synchronized static WebDriver getDriver(String browser) {
                // String browser ==>  it originally comes from xml file to test base class, from test base it comes here

                if (driver == null) {
                    // first we check if the value from xml file is null or not
                    // if the value from xml file NOT null we use
                    // the value from xml file IS null, we get the browser from properties file

                    browser = browser == null ? ConfigurationReader.getProperty("browser") : browser;

                    switch (browser) {
                        case "chrome":
                            WebDriverManager.chromedriver().setup();
                            driver = new ChromeDriver();
                            break;
                        case "chromeHeadless":
                            WebDriverManager.chromedriver().setup();
                            driver = new ChromeDriver(new ChromeOptions().setHeadless(true));
                            break;

                        case "firefox":
                            WebDriverManager.firefoxdriver().setup();
                            driver = new FirefoxDriver();
                            break;
                        case "firefoxHeadless":
                            WebDriverManager.firefoxdriver().setup();
                            driver = new FirefoxDriver(new FirefoxOptions().setHeadless(true));
                            break;

                        case "ie":
                            if (System.getProperty("os.name").toLowerCase().contains("mac"))
                                throw new WebDriverException("You are operating Mac OS which doesn't support Internet Explorer");
                            WebDriverManager.iedriver().setup();
                            driver = new InternetExplorerDriver();
                            break;

                        case "edge":
                            WebDriverManager.edgedriver().setup();
                            driver = new EdgeDriver();
                            break;
                        case "safari":
                            if (System.getProperty("os.name").toLowerCase().contains("windows"))
                                throw new WebDriverException("You are operating Windows OS which doesn't support Safari");
                            WebDriverManager.getInstance(SafariDriver.class).setup();
                            driver = new SafariDriver();
                            break;
                        default:
                            throw new RuntimeException("Illegal browser type!");
                    }
                }
                return driver;
            }

            public static WebDriver getDriver() {

                return getDriver(null);
            }

            public  static void closeDriver() {
                if (driver != null) {
                    driver.quit();
                    driver = null;
                }
            }
        }

*/

    }
}
