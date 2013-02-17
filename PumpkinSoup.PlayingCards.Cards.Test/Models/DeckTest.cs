using System;
using System.Linq;
using MbUnit.Framework;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Cards.Models;
using PumpkinSoup.PlayingCards.Interfaces;
using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Cards.Test.Models
{
	/// <summary>
	///This is a test class for DeckTest and is intended
	///to contain all DeckTest Unit Tests
	///</summary>
	[TestFixture]
	public class DeckTest
	{
		private ICardFactory _cardFactory;
		private IDeckFactory _deckFactory;
		private IDeck _deck;

		[FixtureSetUp]
		public void FixtureSetUp()
		{
			_cardFactory = new StandardCardFactory();
			_deckFactory = new StandardDeckFactory();
		}

		[SetUp]
		public void SetUp()
		{
			var cards = new List<ICard>();
			for (int i = 0; i < 52; i++)
			{
				cards.Add(_cardFactory.CreateCard(i));
			}

			_deck = _deckFactory.CreateDeck(cards);
		}

		/// <summary>
		///A test for Deck Constructor
		///</summary>
		[Test]
		public void DeckConstructorTest()
		{
			var target = new Deck();

			Assert.IsNotNull(target);
		}

		/// <summary>
		///A test for Burn
		///</summary>
		[Test]
		[Row(0)]
		[Row(1)]
		[Row(52)]
		[Row(-1, ExpectedException = typeof(ArgumentOutOfRangeException))]
		[Row(53, ExpectedException = typeof(ArgumentOutOfRangeException))]
		public void BurnTest(int numberToBurn)
		{
			var startCardCount = _deck.Count;

			_deck.Burn(numberToBurn);

			Assert.AreEqual(startCardCount - numberToBurn, _deck.Count);
		}

		/// <summary>
		///A test for Deal
		///</summary>
		[Test]
		[Row(0)]
		[Row(1)]
		[Row(52)]
		[Row(-1, typeof(ArgumentOutOfRangeException))]
		[Row(53, ExpectedException = typeof(ArgumentOutOfRangeException))]
		public void DealTest(int numberToDeal)
		{
			var deckSize = _deck.Count;
			var dealt = _deck.Deal(numberToDeal);

			Assert.IsNotNull(dealt);
			Assert.AreEqual(dealt.Count(), numberToDeal);
			Assert.AreEqual(deckSize, dealt.Count() + numberToDeal);
		}

		/// <summary>
		///A test for Shuffle
		///</summary>
		[Test]
		public void ShuffleTest()
		{
			var originalDeck = _deck;
			_deck.Shuffle();

			bool different = false;
			while (_deck.Count > 0 && !different)
			{
				different = (_deck.Deal() == originalDeck.Deal());
			}
			
			Assert.AreEqual(true, different);
		}

		/// <summary>
		///A test for Count
		///</summary>
		[Test]
		public void CountTest()
		{
			var originalCount = _deck.Count;

			for (int i = 1; i <=
				originalCount; i++)
			{
				_deck.Burn();
				Assert.AreEqual(originalCount, i + _deck.Count);
			}
		}

		/// <summary>
		///A test for IsEmpty
		///</summary>
		[Test]
		public void IsEmptyTest()
		{
			var originalLength = _deck.Count;
			for (int i = 0; i < originalLength - 1; i++)
			{
				Assert.AreEqual(false, _deck.IsEmpty);
				_deck.Burn();
			}

			Assert.AreEqual(true, _deck.IsEmpty);
		}
	}
}
