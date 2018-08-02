using System;
using System.Collections.Generic;
using System.Text;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PumpkinSoup.PlayingCards.Cards.Test.Factories
{
	[TestClass]
	public class StandardDeckFactoryTest
	{
		private StandardDeckFactory _factory;

		[TestInitialize]
		public void FixtureSetUp()
		{
			_factory = new StandardDeckFactory();
			Assert.IsNotNull(_factory);
		}

		[TestMethod]
		public void CreateDeckTest()
		{
			var deck = _factory.CreateDeck();

			Assert.IsNotNull(deck);
		}

		// [TestMethod]
		// public void CreateDeckTest(params ICard[] cards)
		// {
			
		// 	var deck = _factory.CreateDeck(cards);

		// 	Assert.IsNotNull(deck);
		// 	Assert.AreEqual(52, deck.Count);
		// 	Assert.AreEqual(false, deck.IsEmpty);
		// }
	}
}
