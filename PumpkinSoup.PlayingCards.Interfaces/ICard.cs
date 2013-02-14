using System;
using System.Collections.Generic;

namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface ICard : IComparable<ICard>, IEqualityComparer<ICard>
	{
		int Suit { get; }
		int Value { get; }
	}
}