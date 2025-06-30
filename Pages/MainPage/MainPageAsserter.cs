namespace TodoMvcSystemTests.Pages.MainPage
{
    public partial class MainPage
    {
        public void AssertNewItemIsAdded(string title)
        {
            this.ActiveItemsFilterAnchor.Click();
            Assert.That(this.FirstTableItem.Text, Is.EqualTo(title),
                $"Item with title {title} wasn't added to the table.");
        }

        public void AssertItemIsDeleted(string title)
        {
            Assert.That(this.AllTableListItems.Any(item => item.Text.Equals(title, StringComparison.OrdinalIgnoreCase)), Is.False,
                "The item was not deleted as it still appears on the table.");
        }

        public void AssertItemsLeftNumber(int num)
        {
            var itemsLeft = this.GetItemsLeftNumber();
            Assert.That(itemsLeft, Is.EqualTo(num),
                $"The number of active items is not as expected. Current number: {itemsLeft}");
        }

        public void AssertCompletedItemsNumber(int num)
        {
            var activeItems = this.GetCompletedItemsNumber();
            Assert.That(activeItems, Is.EqualTo(num),
                $"The number of completed items is not as expected. Current number: {activeItems}");
        }

        public void AssertItemIsEdited(string editedItemTitle)
        {
            var editedItem = this.GetElementFromTableByTitle(editedItemTitle);
            Assert.That(editedItem, Is.Not.Null, "An item with edited title does not appear in the items table.");
        }
    }
}
