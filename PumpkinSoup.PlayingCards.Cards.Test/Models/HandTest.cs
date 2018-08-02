using System.Linq;
using NUnit.Framework;
using PumpkinSoup.PlayingCards.Cards.Exceptions;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Cards.Models;
using System;
using PumpkinSoup.PlayingCards.Interfaces;
using System.Collections.Generic;
using System.Collections;
using PumpkinSoup.PlayingCards.Cards.Test.Attributes;

namespace PumpkinSoup.PlayingCards.Cards.Test.Models
{
    
    
    /// <summary>
    ///This is a test class for HandTest and is intended
    ///to contain all HandTest Unit Tests
    ///</summary>
	[TestFixture]
	public class HandTest
    {
	    private ICardFactory _cardFactory;
		private ICard _card1;
		private ICard _card2;
		private ICard _card3;

	    private IHand _hand;

		[SetUp]
		public void FixtureSetUp()
		{
			_cardFactory = new StandardCardFactory();
			_card1 = _cardFactory.CreateCard(1);
			_card2 = _cardFactory.CreateCard(2);
			_card3 = _cardFactory.CreateCard(3);
		}

		[SetUp]
		public void SetUp()
		{
			_hand = new Hand();
		}

		/// <summary>
		///A test for Hand Constructor
		///</summary>
		[Test]
		public void HandConstructorTest()
		{
			Assert.IsNotNull(_hand);	
		}

		/// <summary>
		///A test for Add
		///</summary>
		[Test]
		public void AddTest()
		{
			int cardValue = 10;
			int cardSuit = 2;

			_hand.Add(_cardFactory.CreateCard(cardSuit, cardValue));

			Assert.AreEqual(true, _hand.Any(x => x.Value == cardValue && x.Suit == cardSuit));
		}

		/// <summary>
		///A test for Add that tries to add the same card twice
		///</summary>
		[Test]
		[ExpectedException(typeof(CheatingException))]
		public void AddTestWithDuplicate()
		{
			int cardValue = 10;
			int cardSuit = 2;

			var card = _cardFactory.CreateCard(cardSuit, cardValue);

			_hand.Add(card);
			_hand.Add(card);

			Assert.Fail("Expected 'CheatingException' but did not receive one");
		}

		/// <summary>
		///A test for Add
		///</summary>
		[Test]
		public void AddRangeTest()
		{
			var cards = new List<ICard>();

			cards.Add(_cardFactory.CreateCard(1, 2));
			cards.Add(_cardFactory.CreateCard(3, 4));
			cards.Add(_cardFactory.CreateCard(5, 2));

			_hand.Add(cards);
			
			Assert.AreEqual(cards.Count, _hand.Count);
		}

		/// <summary>
		///A test for Clear
		///</summary>
		[Test]
		public void ClearTest()
		{
			_hand.Add(_cardFactory.CreateCard(1));
			_hand.Add(_cardFactory.CreateCard(2));
			_hand.Add(_cardFactory.CreateCard(3));

			Assert.AreEqual(3, _hand.Count);

			_hand.Clear();

			Assert.AreEqual(0, _hand.Count);
		}
		
		/// <summary>
		///A test for GetEnumerator
		///</summary>
		[Test]
		public void GetEnumeratorTest()
		{
			Hand target = new Hand(); // TODO: Initialize to an appropriate value
			IEnumerator<ICard> expected = null; // TODO: Initialize to an appropriate value
			IEnumerator<ICard> actual;
			actual = target.GetEnumerator();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Remove
		///</summary>
		[Test]
		public void RemoveTest()
		{
			_hand.Add(_card1, _card2, _card3);

			_hand.Remove(_card3);

			Assert.IsTrue(_hand.Contains(_card1));
			Assert.IsTrue(_hand.Contains(_card2));
			Assert.IsFalse(_hand.Contains(_card3));

			_hand.Remove(_card1);

			Assert.IsFalse(_hand.Contains(_card1));
			Assert.IsTrue(_hand.Contains(_card2));
			Assert.IsFalse(_hand.Contains(_card3));

			_hand.Remove(_card2);

			Assert.IsFalse(_hand.Contains(_card1));
			Assert.IsFalse(_hand.Contains(_card2));
			Assert.IsFalse(_hand.Contains(_card3));

			Assert.AreEqual(0, _hand.Count);
		}

		/// <summary>
		///A test for Remove
		///</summary>
		[Test]
		public void RemoveRangeTest()
		{
			Assert.AreEqual(0, _hand.Count);

			_hand.Add(_card1);
			_hand.Add(_card2);
			_hand.Add(_card3);

			_hand.Remove(_card1, _card3);

			Assert.AreEqual(1, _hand.Count);
			Assert.IsFalse(_hand.Contains(_card1));
			Assert.IsTrue(_hand.Contains(_card2));
			Assert.IsFalse(_hand.Contains(_card3));
		}

		/// <summary>
		///A test for System.Collections.IEnumerable.GetEnumerator
		///</summary>
		[Test]
		public void GetEnumeratorTest1()
		{
			IEnumerable target = new Hand(); // TODO: Initialize to an appropriate value
			IEnumerator expected = null; // TODO: Initialize to an appropriate value
			IEnumerator actual;
			actual = target.GetEnumerator();
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Count
		///</summary>
		[Test]
		public void CountTest()
		{
			Assert.AreEqual(0, _hand.Count);

			_hand.Add(_card1);
			Assert.AreEqual(1, _hand.Count);
		}

		/// <summary>
		///A test for MaxSize
		///</summary>
		[Test]
		[ExpectedException(typeof(TooManyCardsInHandException))]
		public void MaxSizeTest()
		{
			var limitedSizeHand = new Hand(2);
			limitedSizeHand.Add(_card1);
			limitedSizeHand.Add(_card2);
			limitedSizeHand.Add(_card3);
			
			Assert.Fail("Expected exception was not thrown");
		}
	}
}
