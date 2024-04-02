using System.Text.RegularExpressions;

namespace _14.Lab4.UnitTests
{
	public class Tests
	{
		public Item _item;
		public ItemManager _itemManager;

		[SetUp]
		public void Setup()
		{
			_itemManager = new ItemManager();
		}

		[Test]
		public void Test_AddItem_With_NameIsWordAndSmallerThan50()
		{
			_item = new Item(1, "Test");

			if (Regex.IsMatch(_item.Name, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.AddItem(_item);
			}

			Assert.IsTrue(_itemManager._lstItems.Contains(_item));
		}

		[Test]
		public void Test_AddItem_With_NameIsWordAndGreaterThan50()
		{
			_item = new Item(1, "TestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTestTest");

			if (Regex.IsMatch(_item.Name, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.AddItem(_item);
			}

			Assert.IsTrue(_itemManager._lstItems.Contains(_item));
		}

		[Test]
		public void Test_AddItem_With_NameisNumber()
		{
			_item = new Item(1, "TestTestTe");

			if (!Regex.IsMatch(_item.Name, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.AddItem(_item);
			}

			Assert.IsTrue(_itemManager._lstItems.Contains(_item));
		}

		[Test]
		public void Test_UpdateItem_With_NameIsWordAndSmallerThan50()
		{
			_item = new Item(1, "Test");
			_itemManager.AddItem(_item);

			string newName = "Testabc";
			if (Regex.IsMatch(newName, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.UpdateItem(1, newName);
			}

			Assert.AreEqual(newName, _item.Name);
		}

		[Test]
		public void Test_UpdateItem_With_NameIsWordAndGreaterThan50()
		{
			_item = new Item(1, "Test");
			_itemManager.AddItem(_item);

			string newName = "TestabcTestabcTestabcTestabcTestabcTestabcTestabcTestabcTestabcTestabcTestabcTestabc";
			if (Regex.IsMatch(newName, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.UpdateItem(1, newName);
			}

			Assert.AreEqual(newName, _item.Name);
		}

		[Test]
		public void Test_UpdateItem_With_NameisNumber()
		{
			_item = new Item(1, "Test");
			_itemManager.AddItem(_item);

			string newName = "TestQA1";
			if (Regex.IsMatch(newName, "^[a-zA-Z]{1,50}$"))
			{
				_itemManager.UpdateItem(1, newName);
			}

			Assert.AreNotEqual(newName, _item.Name);
		}

		[Test]
		public void Test_Delete_WithValidID()
		{
			_item = new Item(1, "Test");
			_itemManager.AddItem(_item);

			_itemManager.DeleteItem(1);

			Assert.IsFalse(_itemManager._lstItems.Contains(_item));
		}

		[Test]
		public void Test_Delete_WithInvalidID()
		{
			_item = new Item(1, "Test");
			_itemManager.AddItem(_item);

			_itemManager.DeleteItem(2);

			Assert.IsFalse(_itemManager._lstItems.Contains(_item));
		}
	}
}