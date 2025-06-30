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
            this._driver = DriverFactory.CreateDriver(_browserType);
            this._mainPage = new MainPage(_driver);
            this._actionsBuilder = new Actions(_driver);

            this._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            this._driver.Navigate().GoToUrl(ConfigManager.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            this._driver?.Dispose();
        }
    }
}
