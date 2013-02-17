using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Test.Factories
{
	[TestFixture]
	public class StandardDeckFactoryTest
	{
		private StandardDeckFactory _factory;

		[FixtureSetUp]
		public void FixtureSetUp()
		{
			_factory = new StandardDeckFactory();
			Assert.IsNotNull(_factory);
		}

		[Test]
		public void CreateDeckTest()
		{
			var deck = _factory.CreateDeck();

			Assert.IsNotNull(deck);
		}

		[Test]
		[Row()]
		public void CreateDeckTest(params ICard[] cards)
		{
			var deck = _factory.CreateDeck(cards);

			Assert.IsNotNull(deck);
			Assert.AreEqual(52, deck.Count);
			Assert.AreEqual(false, deck.IsEmpty);
		}
	}
}
