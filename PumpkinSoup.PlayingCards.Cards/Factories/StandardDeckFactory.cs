using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Factories
{
	public class StandardDeckFactory : IDeckFactory
	{
		public IDeck CreateDeck()
		{
			throw new NotImplementedException();
		}

		public IDeck CreateDeck(IEnumerable<ICard> cards)
		{
			throw new NotImplementedException();
		}
	}
}
