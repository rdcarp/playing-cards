using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IDeck
	{
		bool IsEmpty { get; }
		void Shuffle();

		void Burn(int numberToBurn = 1);
		ICard Deal();
		IEnumerable<ICard> Deal(int numberToDeal);
	}
}