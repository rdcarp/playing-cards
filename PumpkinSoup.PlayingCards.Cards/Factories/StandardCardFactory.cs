using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Factories
{
	public class StandardCardFactory : ICardFactory
	{
		public ICard CreateCard(int suit, int value)
		{
			throw new NotImplementedException();
		}

		public ICard CreateCard(int index)
		{
			throw new NotImplementedException();
		}
	}
}
