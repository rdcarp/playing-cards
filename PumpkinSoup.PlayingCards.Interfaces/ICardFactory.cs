namespace PumpkinSoup.PlayingCards.Interfaces
{
	public interface ICardFactory
	{
		ICard CreateCard(int suit, int value);
		ICard CreateCard(int index);
	}
}