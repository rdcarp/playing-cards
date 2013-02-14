using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Factories
{
	public class StandardHandFactory : IHandFactory
	{
		public IHand CreateHand()
		{
			throw new NotImplementedException();
		}

		public IHand CreateHand(IEnumerable<ICard> cards)
		{
			throw new NotImplementedException();
		}
	}
}
