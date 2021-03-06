﻿using MbUnit.Framework;
using PumpkinSoup.PlayingCards.Cards.Factories;
using PumpkinSoup.PlayingCards.Cards.Models;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Test.Models
{
	/// <summary>
	///This is a test class for CardTest and is intended
	///to contain all CardTest Unit Tests
	///</summary>
	[TestFixture]
	public class CardTest
	{
		private ICardFactory _cardFactory;
		private ICard _card1;
		private ICard _card2;
		private ICard _card3;
		private ICard _card4;

		[FixtureSetUp]
		public void FixtureSetUp()
		{
			_cardFactory = new StandardCardFactory();

			_card1 = _cardFactory.CreateCard(10);
			_card2 = _cardFactory.CreateCard(20);
			_card3 = _cardFactory.CreateCard(30);
			_card4 = _cardFactory.CreateCard(10);
		}

		/// <summary>
		///A test for Card Constructor
		///</summary>
		[Test]
		public void CardConstructorTest()
		{
			var card = new Card();

			Assert.IsNotNull(card);
		}

		/// <summary>
		///A test for CompareTo
		///</summary>
		[Test]
		public void CompareToTest()
		{
			var comparrison = _card1.CompareTo(_card2);
			Assert.LessThan(comparrison, 0);

			comparrison = _card3.CompareTo(_card2);
			Assert.GreaterThan(comparrison, 0);

			comparrison = _card1.CompareTo(_card4);
			Assert.AreEqual(comparrison, 0);
		}

		/// <summary>
		///A test for Equals
		///</summary>
		[Test]
		[Row(10, 20, false)]
		[Row(10, 40, false)]
		[Row(10, 10, true)]
		public void EqualsTest(int index1, int index2, bool expected)
		{
			bool actual = _card1.Suit == _card2.Suit && _card1.Value == _card2.Value;

			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for GetHashCode
		///</summary>
		[Test]
		public void GetHashCodeTest()
		{
			Card target = new Card(); // TODO: Initialize to an appropriate value
			ICard obj = null; // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			actual = target.GetHashCode(obj);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Suit
		///</summary>
		[Test]
		public void SuitTest()
		{
			for (int i = 0; i < 54; i++)
			{
				var target = _cardFactory.CreateCard(i);
				
				Assert.Between(target.Suit, 1, 4);
			}
		}

		/// <summary>
		///A test for Value
		///</summary>
		[Test]
		public void ValueTest(int index)
		{
			for (int i = 0; i < 54; i++)
			{
				var target = _cardFactory.CreateCard(index);

				Assert.Between(target.Value, 2, 14);
			}
		}
	}
}
