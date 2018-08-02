using System;
using System.Collections.Generic;
using System.Text;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Cards.Models;
using PumpkinSoup.PlayingCards.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PumpkinSoup.PlayingCards.Cards.Test.Factories
{
	[TestClass]
	public class StandardHandFactoryTest
	{
		private static StandardHandFactory _factory;
		private static List<ICard> someUniqueCards;
		private static List<ICard> someCardsWithDoublers;
		private static List<ICard> emptyCardList;

		[TestInitialize]
		public void FixtureSetUp()
		{
			_factory = new StandardHandFactory();

			Assert.IsNotNull(_factory);

			var cardFactory = new StandardCardFactory();
			someUniqueCards = new List<ICard> {cardFactory.CreateCard(45), cardFactory.CreateCard(12), cardFactory.CreateCard(6)};
			someCardsWithDoublers = new List<ICard>
				{
					cardFactory.CreateCard(12),
					cardFactory.CreateCard(35),
					cardFactory.CreateCard(12)
				};

			emptyCardList =new List<ICard>();

		}

		[TestMethod]
		public void CreateHandTest()
		{
			var hand = _factory.CreateHand();

			Assert.IsNotNull(hand);
			Assert.AreEqual(0, hand.Count);
		}

		[TestMethod]
		public void CreateHandDistinctCardsTest()
		{
			var hand = _factory.CreateHand(someUniqueCards);

			Assert.IsNotNull(hand);
			Assert.AreEqual(someUniqueCards.Count, hand.Count);
		}
		
		[TestMethod]
		public void CreateHandDuplicateCardsTest()
		{
			var hand = _factory.CreateHand(someCardsWithDoublers);

			Assert.IsNotNull(hand);
			Assert.AreEqual(someCardsWithDoublers.Count, hand.Count);
		}

		[TestMethod]
		public void CreateHandEmptyCardListTest()
		{
			var hand = _factory.CreateHand(emptyCardList);

			Assert.IsNotNull(hand);
			Assert.AreEqual(emptyCardList.Count, hand.Count);
		}
	}
}
