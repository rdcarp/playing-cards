using PumpkinSoup.PlayingCards.Cards.Factories;
using NUnit.Framework;

namespace PumpkinSoup.PlayingCards.Cards.Test
{


	/// <summary>
	///This is a test class for StandardCardFactoryTest and is intended
	///to contain all StandardCardFactoryTest Unit Tests
	///</summary>
	[TestFixture]
	public class StandardCardFactoryTest
	{
		private StandardCardFactory _factory;

		[SetUp]
		public void StandardCardFactorySetup()
		{
			_factory = new StandardCardFactory();
		}

		/// <summary>
		///A test for StandardCardFactory Constructor
		///</summary>
		[TestCase]
		public void StandardCardFactoryConstructorTest()
		{
			var cardFactory = new StandardCardFactory();

			Assert.IsNotNull(cardFactory);
		}

		// [TestMethod]
		// [Row(1, 1)]
		// [Row(5, 1, ExpectedException = typeof(ArgumentOutOfRangeException), ExpectedExceptionMessage = "Suit value must be 0 - 3")]
		// [Row(-1, 1, ExpectedException = typeof(ArgumentOutOfRangeException), ExpectedExceptionMessage = "Suit value must be 0 - 3")]
		// [Row(1, 15, ExpectedException = typeof(ArgumentOutOfRangeException), ExpectedExceptionMessage = "Card value must be 0 - 12")]
		// [Row(1, -1, ExpectedException = typeof(ArgumentOutOfRangeException), ExpectedExceptionMessage = "Card value must be 0 - 12")]
		// [Row(3, 12)]
		// public void CreateCard(int suit, int value)
		// {
		// 	var card = _factory.CreateCard(suit, value);

		// 	Assert.IsNotNull(card);
		// 	Assert.AreEqual(suit, card.Suit);
		// 	Assert.AreEqual(value, card.Value);
		// }

		// [Test]
		// [Row(0)]
		// [Row(51)]
		// [Row(52, ExpectedException = typeof(ArgumentOutOfRangeException))]
		// [Row(-1, ExpectedException = typeof(ArgumentOutOfRangeException))]
		// public void CreateCard(int index)
		// {
		// 	var card = _factory.CreateCard(index);

		// 	Assert.IsNotNull(card);

		// 	int expectedSuit = index/13;
		// 	int expectedValue = index%13;

		// 	Assert.AreEqual(expectedSuit, card.Suit);
		// 	Assert.AreEqual(expectedValue, card.Value);
		// }
	}
}