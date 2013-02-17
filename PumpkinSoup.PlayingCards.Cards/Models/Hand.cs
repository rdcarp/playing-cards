using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PumpkinSoup.PlayingCards.Interfaces;

namespace PumpkinSoup.PlayingCards.Cards.Models
{
	public class Hand : IHand
	{
		private int? _maxSize;
		private int _count;
		private bool _readOnly;

		internal Hand() : this(null)
		{	
		}
		internal Hand(int maxSize) : this(null, false, maxSize)
		{
		}
		internal Hand(IEnumerable<ICard> cards, bool readOnly = false, int? maxSize = null)
		{
			Add(cards);
			_readOnly = readOnly;
			_maxSize = maxSize;
		}

		public IEnumerator<ICard> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public int? MaxSize
		{
			get { return _maxSize; }
		}

		public int Count
		{
			get { return _count; }
		}

		public bool ReadOnly
		{
			get { return _readOnly; }
		}

		public void Add(params ICard[] cards)
		{
			throw new NotImplementedException();
		}

		public void Add(IEnumerable<ICard> cards)
		{
			throw new NotImplementedException();
		}

		public void Remove(params ICard[] cards)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			throw new NotImplementedException();
		}
	}
}
