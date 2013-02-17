using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface IHand : IEnumerable<ICard>
	{
		int? MaxSize { get; }
		int Count { get; }
		bool ReadOnly { get; }

		void Add(params ICard[] cards);
		void Add(IEnumerable<ICard> cards); 
		void Remove(params ICard[] cards);
		void Clear();
	}
}