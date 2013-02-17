using MbUnit.Framework;
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
		/// <summary>
		///A test for Card Constructor
		///</summary>
		[Test]
		public void CardConstructorTest()
		{
			Card target = new Card();
			Assert.Inconclusive("TODO: Implement code to verify target");
		}

		/// <summary>
		///A test for CompareTo
		///</summary>
		[Test]
		public void CompareToTest()
		{
			Card target = new Card(); // TODO: Initialize to an appropriate value
			ICard other = null; // TODO: Initialize to an appropriate value
			int expected = 0; // TODO: Initialize to an appropriate value
			int actual;
			actual = target.CompareTo(other);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Equals
		///</summary>
		[Test]
		public void EqualsTest()
		{
			Card target = new Card(); // TODO: Initialize to an appropriate value
			ICard x = null; // TODO: Initialize to an appropriate value
			ICard y = null; // TODO: Initialize to an appropriate value
			bool expected = false; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.Equals(x, y);
			Assert.AreEqual(expected, actual);
			Assert.Inconclusive("Verify the correctness of this test method.");
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
			Card target = new Card(); // TODO: Initialize to an appropriate value
			int actual;
			actual = target.Suit;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}

		/// <summary>
		///A test for Value
		///</summary>
		[Test]
		public void ValueTest()
		{
			Card target = new Card(); // TODO: Initialize to an appropriate value
			int actual;
			actual = target.Value;
			Assert.Inconclusive("Verify the correctness of this test method.");
		}
	}
}
