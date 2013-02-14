using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IHandFactory
	{
		IHand CreateHand();
		IHand CreateHand(IEnumerable<ICard> cards);
	}
}