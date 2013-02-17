using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IDeck : IEnumerable<ICard>
	{
		bool IsEmpty { get; }
		int Count { get; }

		void Shuffle();
		void Burn(int numberToBurn = 1);
		ICard Deal();
		IEnumerable<ICard> Deal(int numberToDeal);
	}
}