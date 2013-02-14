using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IHand : ICollection<ICard>
	{
		int? MaxSize { get; }

		void Add(params ICard[] cards);
		void Remove(params ICard[] cards);
	}
}