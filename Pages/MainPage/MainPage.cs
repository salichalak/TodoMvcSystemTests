using OpenQA.Selenium;
using System.Text.RegularExpressions;
using TodoMvcSystemTests.TestData;

namespace TodoMvcSystemTests.Pages.MainPage
{
    public partial class MainPage : BasePage
    {
        public MainPage(IWebDriver driver) : base(driver) { }

        public void AddItem(string title)
        {
            this.NewItemInput.SendKeys(title);
            this.NewItemInput.SendKeys(Keys.Enter);
        }

        public void RemoveItem(string title)
        {
            this._actionsBuilder.MoveToElement(this.GetElementFromTableByTitle(title)).Build().Perform();
            this.DeleteButton.Click();
        }

        public int GetItemsLeftNumber()
        {
            var match = Regex.Match(this.ItemsLeftSpan.Text, @"^\d+");

            return int.Parse(match.Value);
        }

        public int GetCompletedItemsNumber()
        {
            var match = Regex.Match(this.ClearCompletedButton.Text, @"\((\d+)\)");

            return int.Parse(match.Groups[1].Value);
        }

        public void MarkItemAsCompleted(string title)
        {
            this.ItemCompleteButtonByTitle(title).Click();
        }

        public void FeedTestData()
        {
            foreach (var item in CommonTestData.TestItemsStub)
            {
                this.AddItem(item);
            }
        }

        public void EditItem(string itemToEdit, string newTitle)
        {
            this._actionsBuilder.DoubleClick(this.GetElementFromTableByTitle(itemToEdit)).Perform();

            this.EditBoxInput.SendKeys(Keys.Control + "a" + Keys.Delete);
            this.EditBoxInput.SendKeys(newTitle);
            this.EditBoxInput.SendKeys(Keys.Enter);
        }
    }
}
