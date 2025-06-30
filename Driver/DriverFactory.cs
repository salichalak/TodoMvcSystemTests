using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TodoMvcSystemTests.TestData;

namespace TodoMvcSystemTests.Driver
{
    public static class DriverFactory
    {
        public static IWebDriver CreateDriver(BrowserType browser)
        {
            switch (browser)
            {
                case BrowserType.Chrome:
                    var options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    options.AddExcludedArgument("disable-popup-blocking");

                    return new ChromeDriver(options);

                case BrowserType.Firefox:
                    var firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("--width=1920");
                    firefoxOptions.AddArgument("--height=1080");

                    return new FirefoxDriver(firefoxOptions);

                default:
                    throw new ArgumentException("Not supported browser vendor.");
            }
        }
    }
}
