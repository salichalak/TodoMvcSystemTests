using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TodoMvcSystemTests.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver? _driver;
        protected WebDriverWait? _wait;
        protected Actions _actionsBuilder;

        protected BasePage(IWebDriver driver)
        {
            this._driver = driver;
            this._wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            this._actionsBuilder = new Actions(this._driver);
        }
    }
}
