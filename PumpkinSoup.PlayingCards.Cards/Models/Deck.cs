using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Models
{
	public class Deck : IDeck
	{
		private bool _isEmpty;

		internal Deck()
		{
			
		}

		public bool IsEmpty
		{
			get { return _isEmpty; }
		}

		public void Shuffle()
		{
			throw new NotImplementedException();
		}

		public void Burn(int numberToBurn = 1)
		{
			throw new NotImplementedException();
		}

		public ICard Deal()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ICard> Deal(int numberToDeal)
		{
			throw new NotImplementedException();
		}
	}
}
