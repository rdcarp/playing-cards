using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Models
{
	public class Card : ICard
	{
		private int _suit;
		private int _value;

		public int CompareTo(ICard other)
		{
			throw new NotImplementedException();
		}

		public bool Equals(ICard x, ICard y)
		{
			throw new NotImplementedException();
		}

		public int GetHashCode(ICard obj)
		{
			throw new NotImplementedException();
		}

		public int Suit
		{
			get { return _suit; }
		}

		public int Value
		{
			get { return _value; }
		}
	}
}
