using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TodoMvcSystemTests.Config;
using TodoMvcSystemTests.Driver;
using TodoMvcSystemTests.Pages.MainPage;
using TodoMvcSystemTests.TestData;

namespace TodoMvcSystemTests.Tests
{
    public abstract class BaseTest
    {
        protected readonly BrowserType _browserType = BrowserType.Chrome;
        protected MainPage _mainPage;
        protected IWebDriver _driver;
        protected Actions _actionsBuilder;

        [SetUp]
        public void Setup()
        {
            _driver = DriverFactory.CreateDriver(_browserType);
            _mainPage = new MainPage(_driver);
            _actionsBuilder = new Actions(_driver);

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.Navigate().GoToUrl(ConfigManager.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Dispose();
        }
    }
}
