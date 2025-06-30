using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace TodoMvcSystemTests.Pages.MainPage
{
    public partial class MainPage
    {
        public IWebElement NewItemInput => this._driver.FindElement(By.ClassName("new-todo"));

        public IWebElement AllItemsFilterAnchor => this._driver.FindElement(By.XPath("//ul[@class='filters']//li/a[text()='All']"));

        public IWebElement ActiveItemsFilterAnchor => this._driver.FindElement(By.XPath("//ul[@class='filters']//li/a[text()='Active']"));

        public IWebElement CompletedItemsFilterAnchor => this._driver.FindElement(By.XPath("//ul[@class='filters']//li/a[text()='Completed']"));

        public IWebElement ClearCompletedButton => this._driver.FindElement(By.ClassName("clear-completed"));

        public IWebElement ItemsLeftSpan => this._driver.FindElement(By.ClassName("todo-count"));

        public IWebElement FirstTableItem => this._driver.FindElement(By.XPath("//ul[@class='todo-list']/li[1]"));

        public IWebElement GetElementFromTableByTitle(string title) => this._driver.FindElement(By.XPath($"//ul[@class='todo-list']//li/div/label[text()='{title}']"));

        public IWebElement DeleteButton => this._driver.FindElement(By.ClassName("destroy"));

        public ReadOnlyCollection<IWebElement> AllTableListItems => this._driver.FindElements(By.XPath("//ul[@class='todo-list']//li/div/label"));

        public IWebElement ItemCompleteButtonByTitle(string title) => this._driver.FindElement(By.XPath($"//ul[@class='todo-list']//li/div/label[text()='{title}']/preceding-sibling::input[@class='toggle']"));

        public IWebElement EditBoxInput => this._driver.FindElement(By.XPath("//li[@class='editing']//input[@name='title']"));
    }
}
