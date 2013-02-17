using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Cards.Models;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Test.Factories
{
	[TestFixture]
	public class StandardHandFactoryTest
	{
		private static StandardHandFactory _factory;
		private static List<ICard> someUniqueCards;
		private static List<ICard> someCardsWithDoublers;
		private static List<ICard> emptyCardList;

		[FixtureSetUp]
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

		[Test]
		public void CreateHandTest()
		{
			var hand = _factory.CreateHand();

			Assert.IsNotNull(hand);
			Assert.AreEqual(0, hand.Count);
		}

		[Test]
		public void CreateHandDistinctCardsTest()
		{
			var hand = _factory.CreateHand(someUniqueCards);

			Assert.IsNotNull(hand);
			Assert.AreEqual(someUniqueCards.Count, hand.Count);
		}
		
		[Test]
		public void CreateHandDuplicateCardsTest()
		{
			var hand = _factory.CreateHand(someCardsWithDoublers);

			Assert.IsNotNull(hand);
			Assert.AreEqual(someCardsWithDoublers.Count, hand.Count);
		}

		[Test]
		public void CreateHandEmptyCardListTest()
		{
			var hand = _factory.CreateHand(emptyCardList);

			Assert.IsNotNull(hand);
			Assert.AreEqual(emptyCardList.Count, hand.Count);
		}
	}
}
