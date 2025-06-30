using TodoMvcSystemTests.TestData;

namespace TodoMvcSystemTests.Tests
{
    [TestFixture]
    public class MainPageTests : BaseTest
    {
        [Test]
        public void AddNewItem()
        {
            this._mainPage.AddItem(CommonTestData.NewItemTitle);

            this._mainPage.AssertNewItemIsAdded(CommonTestData.NewItemTitle);
            this._mainPage.AssertItemsLeftNumber(1);
        }

        [Test]
        public void RemoveItem()
        {
            this._mainPage.FeedTestData();
            this._mainPage.AssertItemsLeftNumber(2);

            this._mainPage.RemoveItem(CommonTestData.ItemToDeleteTitle);
            this._mainPage.AssertItemIsDeleted(CommonTestData.ItemToDeleteTitle);
            this._mainPage.AssertItemsLeftNumber(1);
        }

        [Test]
        public void MarkItemAsCompleted()
        {
            this._mainPage.FeedTestData();
            this._mainPage.AssertItemsLeftNumber(2);

            this._mainPage.MarkItemAsCompleted(CommonTestData.ItemToDeleteTitle);
            this._mainPage.AssertItemsLeftNumber(1);
            this._mainPage.AssertCompletedItemsNumber(1);
        }

        [Test]
        public void EditItem()
        {
            this._mainPage.FeedTestData();
            this._mainPage.AssertItemsLeftNumber(2);

            this._mainPage.EditItem(CommonTestData.NewItemTitle, CommonTestData.EditedItemTitle);
            this._mainPage.AssertItemIsEdited(CommonTestData.EditedItemTitle);
        }
    }
}
