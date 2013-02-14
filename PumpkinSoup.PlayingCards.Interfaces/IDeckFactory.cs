using System.Collections;
using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IDeckFactory
	{
		IDeck CreateDeck();
		IDeck CreateDeck(IEnumerable<ICard> cards);
	}
}